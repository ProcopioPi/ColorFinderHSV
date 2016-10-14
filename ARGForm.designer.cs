namespace ARGOTH
{
    partial class MainFRM
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PCT_CANVAS = new System.Windows.Forms.PictureBox();
            this.LBL_IMAGE_SIZE = new System.Windows.Forms.Label();
            this.BTN_WEB = new System.Windows.Forms.Button();
            this.BTN_OPEN_IMAGE = new System.Windows.Forms.Button();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.BTN_COLOR_FINDER = new System.Windows.Forms.Button();
            this.TXT_MIN = new System.Windows.Forms.TextBox();
            this.TXT_MAX = new System.Windows.Forms.TextBox();
            this.LBL_MIN = new System.Windows.Forms.Label();
            this.LBL_MAX = new System.Windows.Forms.Label();
            this.BTN_PROCESS_FOLDER = new System.Windows.Forms.Button();
            this.LBL_STAT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).BeginInit();
            this.SuspendLayout();
            // 
            // PCT_CANVAS
            // 
            this.PCT_CANVAS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PCT_CANVAS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PCT_CANVAS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PCT_CANVAS.Location = new System.Drawing.Point(354, 117);
            this.PCT_CANVAS.Name = "PCT_CANVAS";
            this.PCT_CANVAS.Size = new System.Drawing.Size(640, 480);
            this.PCT_CANVAS.TabIndex = 0;
            this.PCT_CANVAS.TabStop = false;
            // 
            // LBL_IMAGE_SIZE
            // 
            this.LBL_IMAGE_SIZE.AutoSize = true;
            this.LBL_IMAGE_SIZE.ForeColor = System.Drawing.Color.Silver;
            this.LBL_IMAGE_SIZE.Location = new System.Drawing.Point(53, 15);
            this.LBL_IMAGE_SIZE.Name = "LBL_IMAGE_SIZE";
            this.LBL_IMAGE_SIZE.Size = new System.Drawing.Size(71, 13);
            this.LBL_IMAGE_SIZE.TabIndex = 1;
            this.LBL_IMAGE_SIZE.Text = "IMAGE_SIZE";
            // 
            // BTN_WEB
            // 
            this.BTN_WEB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_WEB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_WEB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTN_WEB.FlatAppearance.BorderSize = 0;
            this.BTN_WEB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_WEB.ForeColor = System.Drawing.Color.DarkGray;
            this.BTN_WEB.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BTN_WEB.Location = new System.Drawing.Point(370, 603);
            this.BTN_WEB.Name = "BTN_WEB";
            this.BTN_WEB.Size = new System.Drawing.Size(65, 27);
            this.BTN_WEB.TabIndex = 42;
            this.BTN_WEB.Text = "WEBCAM";
            this.BTN_WEB.UseVisualStyleBackColor = false;
            this.BTN_WEB.Visible = false;
            this.BTN_WEB.Click += new System.EventHandler(this.BTN_WEB_Click);
            // 
            // BTN_OPEN_IMAGE
            // 
            this.BTN_OPEN_IMAGE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_OPEN_IMAGE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTN_OPEN_IMAGE.FlatAppearance.BorderSize = 0;
            this.BTN_OPEN_IMAGE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_OPEN_IMAGE.ForeColor = System.Drawing.Color.Silver;
            this.BTN_OPEN_IMAGE.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BTN_OPEN_IMAGE.Location = new System.Drawing.Point(12, 31);
            this.BTN_OPEN_IMAGE.Name = "BTN_OPEN_IMAGE";
            this.BTN_OPEN_IMAGE.Size = new System.Drawing.Size(261, 30);
            this.BTN_OPEN_IMAGE.TabIndex = 45;
            this.BTN_OPEN_IMAGE.Text = "OPEN DIRECTORY";
            this.BTN_OPEN_IMAGE.UseVisualStyleBackColor = false;
            this.BTN_OPEN_IMAGE.Click += new System.EventHandler(this.BTN_OPEN_IMAGE_Click);
            // 
            // OFD
            // 
            this.OFD.FileName = "openFileDialog1";
            // 
            // BTN_COLOR_FINDER
            // 
            this.BTN_COLOR_FINDER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_COLOR_FINDER.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.BTN_COLOR_FINDER.Location = new System.Drawing.Point(12, 190);
            this.BTN_COLOR_FINDER.Name = "BTN_COLOR_FINDER";
            this.BTN_COLOR_FINDER.Size = new System.Drawing.Size(261, 30);
            this.BTN_COLOR_FINDER.TabIndex = 46;
            this.BTN_COLOR_FINDER.Text = "FIND COLOR";
            this.BTN_COLOR_FINDER.UseVisualStyleBackColor = true;
            this.BTN_COLOR_FINDER.Click += new System.EventHandler(this.BTN_COLOR_FINDER_Click);
            // 
            // TXT_MIN
            // 
            this.TXT_MIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXT_MIN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_MIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_MIN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TXT_MIN.Location = new System.Drawing.Point(12, 156);
            this.TXT_MIN.Name = "TXT_MIN";
            this.TXT_MIN.Size = new System.Drawing.Size(100, 28);
            this.TXT_MIN.TabIndex = 47;
            this.TXT_MIN.Text = "45";
            this.TXT_MIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXT_MAX
            // 
            this.TXT_MAX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXT_MAX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_MAX.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_MAX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TXT_MAX.Location = new System.Drawing.Point(173, 156);
            this.TXT_MAX.Name = "TXT_MAX";
            this.TXT_MAX.Size = new System.Drawing.Size(100, 28);
            this.TXT_MAX.TabIndex = 48;
            this.TXT_MAX.Text = "95";
            this.TXT_MAX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LBL_MIN
            // 
            this.LBL_MIN.AutoSize = true;
            this.LBL_MIN.ForeColor = System.Drawing.Color.Silver;
            this.LBL_MIN.Location = new System.Drawing.Point(16, 140);
            this.LBL_MIN.Name = "LBL_MIN";
            this.LBL_MIN.Size = new System.Drawing.Size(27, 13);
            this.LBL_MIN.TabIndex = 50;
            this.LBL_MIN.Text = "MIN";
            // 
            // LBL_MAX
            // 
            this.LBL_MAX.AutoSize = true;
            this.LBL_MAX.ForeColor = System.Drawing.Color.Silver;
            this.LBL_MAX.Location = new System.Drawing.Point(186, 140);
            this.LBL_MAX.Name = "LBL_MAX";
            this.LBL_MAX.Size = new System.Drawing.Size(30, 13);
            this.LBL_MAX.TabIndex = 51;
            this.LBL_MAX.Text = "MAX";
            // 
            // BTN_PROCESS_FOLDER
            // 
            this.BTN_PROCESS_FOLDER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_PROCESS_FOLDER.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.BTN_PROCESS_FOLDER.Location = new System.Drawing.Point(19, 306);
            this.BTN_PROCESS_FOLDER.Name = "BTN_PROCESS_FOLDER";
            this.BTN_PROCESS_FOLDER.Size = new System.Drawing.Size(197, 46);
            this.BTN_PROCESS_FOLDER.TabIndex = 52;
            this.BTN_PROCESS_FOLDER.Text = "PROCESS FOLDER";
            this.BTN_PROCESS_FOLDER.UseVisualStyleBackColor = true;
            this.BTN_PROCESS_FOLDER.Click += new System.EventHandler(this.BTN_PROCESS_FOLDER_Click);
            // 
            // LBL_STAT
            // 
            this.LBL_STAT.AutoSize = true;
            this.LBL_STAT.ForeColor = System.Drawing.Color.Silver;
            this.LBL_STAT.Location = new System.Drawing.Point(32, 365);
            this.LBL_STAT.Name = "LBL_STAT";
            this.LBL_STAT.Size = new System.Drawing.Size(0, 13);
            this.LBL_STAT.TabIndex = 53;
            // 
            // MainFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1292, 750);
            this.Controls.Add(this.LBL_STAT);
            this.Controls.Add(this.BTN_PROCESS_FOLDER);
            this.Controls.Add(this.LBL_MAX);
            this.Controls.Add(this.LBL_MIN);
            this.Controls.Add(this.TXT_MAX);
            this.Controls.Add(this.TXT_MIN);
            this.Controls.Add(this.BTN_COLOR_FINDER);
            this.Controls.Add(this.BTN_OPEN_IMAGE);
            this.Controls.Add(this.BTN_WEB);
            this.Controls.Add(this.LBL_IMAGE_SIZE);
            this.Controls.Add(this.PCT_CANVAS);
            this.DoubleBuffered = true;
            this.Name = "MainFRM";
            this.Text = "ARGOTH";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PCT_CANVAS;
        private System.Windows.Forms.Label LBL_IMAGE_SIZE;
        private System.Windows.Forms.Button BTN_WEB;
        private System.Windows.Forms.Button BTN_OPEN_IMAGE;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.Button BTN_COLOR_FINDER;
        private System.Windows.Forms.TextBox TXT_MIN;
        private System.Windows.Forms.TextBox TXT_MAX;
        private System.Windows.Forms.Label LBL_MIN;
        private System.Windows.Forms.Label LBL_MAX;
        private System.Windows.Forms.Button BTN_PROCESS_FOLDER;
        private System.Windows.Forms.Label LBL_STAT;
    }
}

