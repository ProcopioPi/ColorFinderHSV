using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Imaging;
using System.Drawing;

namespace ARGOTH.SNIPS
{
    public unsafe sealed class Convolver
    {
        /*
        public delegate void ProcessProgress(int progress);
        public static event ProcessProgress processProgressEvent;//*/

        private static BitmapData bmRenderData, bmCanvasDat;
        private static Matrix mask;

        private static byte* pRender, pCanvas;
        private static myPixel* pixel, pixOriginal;
        private static float sumaR;
        private static float sumaG;
        private static float sumaB;

        private static float val;
        private static byte r, g, b;
        private static int i, j;

        private static Bitmap bmp;

        private static int x, y;

        public static Bitmap Execute(Bitmap bitmap, Matrix matrix)
        {
            bmp = new Bitmap(bitmap);       

            bmRenderData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);

            bmCanvasDat = bmp.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);

            mask = matrix;

            if (matrix.Size > 0)
            {
                pRender = (byte*)bmRenderData.Scan0.ToPointer();
                pCanvas = (byte*)bmCanvasDat.Scan0.ToPointer();

                pixel = PixelAt(0, 0, pRender, bmRenderData.Width);//moves pointer to
                pixOriginal = PixelAt(0, 0, pCanvas, bmCanvasDat.Width);//moves pointer to

                for (y = (matrix.Size / 2); y < bmRenderData.Height - (matrix.Size / 2); ++y)
                {
                    for (x = (matrix.Size / 2); x < bmRenderData.Width - (matrix.Size / 2); ++x)
                    {
                        Convolve(bmRenderData, bmCanvasDat, matrix.Size);
                    }
                    //UpdateProcessProgress((int)(y * 100 / bitmap.Height));
                }
                bmp.UnlockBits(bmCanvasDat);
                bitmap.UnlockBits(bmRenderData);
            }

            return bitmap;
        }

        private static void Convolve(BitmapData renderDat, BitmapData canvasDat, int size)
        {
            pRender = (byte*)renderDat.Scan0.ToPointer();
            pCanvas = (byte*)bmCanvasDat.Scan0.ToPointer();

            sumaR = 0;
            sumaG = 0;
            sumaB = 0;

            for (j = 0; j < size; j++)
            {
                pixel = PixelAt(x - (size / 2), (j + y) - (size / 2), pRender, renderDat.Width);
                pixOriginal = PixelAt(x - (size / 2), (j + y) - (size / 2), pCanvas, bmCanvasDat.Width);

                for (i = 0; i < size; i++)
                {
                    val = mask[i, j];

                    r = pixOriginal->R;
                    g = pixOriginal->G;
                    b = pixOriginal->B;

                    sumaR += (val * r);
                    sumaG += (val * g);
                    sumaB += (val * b);

                    pixel++;
                    pixOriginal++;
                }
            }

            pixel = PixelAt(x, y, pRender, renderDat.Width);

            sumaR = Math.Abs(sumaR);
            sumaG = Math.Abs(sumaG);
            sumaB = Math.Abs(sumaB);

            pixel->R = (byte)(sumaR);
            pixel->G = (byte)(sumaG);
            pixel->B = (byte)(sumaB);
        }
        
        private static myPixel* PixelAt(int x, int y, byte* pBase, int width)
        {
            return (myPixel*)(((byte*)pBase + y * width * sizeof(myPixel)) + x * sizeof(myPixel));
        }

        public static byte ClampByte(float value)
        {
            return (byte)((value < byte.MinValue) ? byte.MinValue : (value > byte.MaxValue) ? byte.MaxValue : value);
        }//*/
        /*
        private static void UpdateProcessProgress(int value)
        {
            try
            {
                if (processProgressEvent != null)
                    processProgressEvent(value);
            }
            catch (Exception) { }
        }//*/

    }
}
