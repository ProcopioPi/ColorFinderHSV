using System;
using System.Drawing;
using System.Windows.Forms;
using motion;
using VideoSource;
using ASSISTME;
using System.Threading;
using ASSISTME.SNIPS;
using ARGOTH.SNIPS.MON;
using ARGOTH.SNIPS;
using ARGOTH.SNIPS.CNV;
using System.IO;

namespace ARGOTH
{
    public partial class MainFRM : Form
    {
        private static Camera camera = null;
        private static int MIN, MAX;
        private static FileInfo info;
        private static string[] fileEntries;

        private static Bitmap filterBmp;
        private static CaptureDevice localSource;
        private static CaptureDeviceForm form;
        private static Thread thread;
        SobelGx SOBEL_Gx = new SobelGx(3);

        public MainFRM()
        {
            InitializeComponent();
            MIN = 45;
            MAX = 95;
        }

        public void Initialize()
        {
            form = new CaptureDeviceForm();

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                // create video source
                localSource = new CaptureDevice();
                localSource.VideoSource = form.Device;

                // open it
                OpenVideoSource(localSource);
            }
        }

        private void OpenVideoSource(IVideoSource source)
        {
            // create camera
            camera = new Camera(source);
            // start camera
            camera.Start();
            camera.NewFrame += new EventHandler(camera_NewFrame);
        }

        void camera_NewFrame(object sender, EventArgs e)
        {
            Invalidate();

            if (camera != null)
            {
                try
                {
                    camera.Lock();
                    filterBmp = new Bitmap(camera.LastFrame);
                    PCT_CANVAS.Image = Convolver.Execute(filterBmp, SOBEL_Gx);//Sobel.Execute(YUV.Execute(filterBmp));

                    MyDelegates.SetControlTextValue(LBL_IMAGE_SIZE, camera.LastFrame.Size);
                }
                catch (Exception ex)
                {
                    MyDelegates.SetControlTextValue(LBL_IMAGE_SIZE,ex);
                }
                finally
                {
                    camera.Unlock();
                }

                if (camera.FramesReceived % 12 == 0)
                {
                    thread = new Thread(Clean);
                    thread.Start();
                }
            }
        }
        private static void Clean()
        {
            GC.Collect();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
             if (camera != null)
                camera.Stop();
        }

        private void BTN_WEB_Click(object sender, EventArgs e)
        {
            Initialize();
        }

        /// <p>
        /// Evento botón para abrir una imagen y obtener todas las rutas
        /// de los archivos en el directorio.
        /// <p>
        private void BTN_OPEN_IMAGE_Click(object sender, EventArgs e)
        {
            if (OFD.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                info = new FileInfo(OFD.FileName);
                fileEntries = Directory.GetFiles(info.DirectoryName);

                filterBmp = new Bitmap(OFD.FileName);
                filterBmp = new Bitmap(filterBmp);
                Histogram.Execute(filterBmp);
                PCT_CANVAS.Image = filterBmp;
            }
        }

        private void BTN_COLOR_FINDER_Click(object sender, EventArgs e)
        {
            filterBmp = new Bitmap(OFD.FileName);
            filterBmp = new Bitmap(filterBmp);

            MIN = int.Parse(TXT_MIN.Text);
            MAX = int.Parse(TXT_MAX.Text);

            PCT_CANVAS.Image = ColorFinder.Execute(filterBmp,MIN,MAX);
            PCT_CANVAS.Refresh();
        }

        private void BTN_PROCESS_FOLDER_Click(object sender, EventArgs e)
        {
            LBL_STAT.Text = "processing...";
            thread = new Thread(ProcessFolder);
            thread.Start();
        }

        /// <p>
        /// Recursive method that iterates through the directory files
        /// applying the same process
        /// <p>
        private void ProcessFolder()
        {
            DirectoryInfo dirInfo = Directory.CreateDirectory(info.DirectoryName + @"\PROCESS");
            for (int i = 0; i < fileEntries.Length; i++)
            {
                try
                {
                    filterBmp = new Bitmap(fileEntries[i]);
                    ColorFinder.Execute(filterBmp, MIN, MAX).Save(dirInfo.FullName + @"\000" + i + ".PNG");
                }
                catch (Exception) { }
            }
            MyDelegates.SetControlTextValue(LBL_STAT, "Done");
        }
    }
}