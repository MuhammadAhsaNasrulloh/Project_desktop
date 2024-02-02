namespace HotelAlexa
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Guna.UI.Animation.Animation animation1 = new Guna.UI.Animation.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btnReguler = new Guna.UI.WinForms.GunaButton();
            this.btnVIP = new Guna.UI.WinForms.GunaButton();
            this.btnVVIP = new Guna.UI.WinForms.GunaButton();
            this.gunaTransfarantPictureBox1 = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.gunaTransition1 = new Guna.UI.WinForms.GunaTransition(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaTransition1.SetDecoration(this.gunaLabel1, Guna.UI.Animation.DecorationType.None);
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(288, 45);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(390, 31);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "SELAMAT DATANG DI HOTEL ALEXA";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnReguler
            // 
            this.btnReguler.AnimationHoverSpeed = 0.07F;
            this.btnReguler.AnimationSpeed = 0.03F;
            this.btnReguler.BackColor = System.Drawing.Color.Transparent;
            this.btnReguler.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReguler.BorderColor = System.Drawing.Color.Black;
            this.gunaTransition1.SetDecoration(this.btnReguler, Guna.UI.Animation.DecorationType.None);
            this.btnReguler.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReguler.ForeColor = System.Drawing.Color.White;
            this.btnReguler.Image = null;
            this.btnReguler.ImageSize = new System.Drawing.Size(20, 20);
            this.btnReguler.Location = new System.Drawing.Point(175, 271);
            this.btnReguler.Name = "btnReguler";
            this.btnReguler.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnReguler.OnHoverBorderColor = System.Drawing.Color.SandyBrown;
            this.btnReguler.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReguler.OnHoverImage = null;
            this.btnReguler.OnPressedColor = System.Drawing.Color.Peru;
            this.btnReguler.Radius = 5;
            this.btnReguler.Size = new System.Drawing.Size(154, 152);
            this.btnReguler.TabIndex = 2;
            this.btnReguler.Text = "REGULER";
            this.btnReguler.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReguler.Click += new System.EventHandler(this.btnReguler_Click);
            // 
            // btnVIP
            // 
            this.btnVIP.AnimationHoverSpeed = 0.07F;
            this.btnVIP.AnimationSpeed = 0.03F;
            this.btnVIP.BackColor = System.Drawing.Color.Transparent;
            this.btnVIP.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVIP.BorderColor = System.Drawing.Color.Black;
            this.gunaTransition1.SetDecoration(this.btnVIP, Guna.UI.Animation.DecorationType.None);
            this.btnVIP.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVIP.ForeColor = System.Drawing.Color.White;
            this.btnVIP.Image = null;
            this.btnVIP.ImageSize = new System.Drawing.Size(20, 20);
            this.btnVIP.Location = new System.Drawing.Point(395, 271);
            this.btnVIP.Name = "btnVIP";
            this.btnVIP.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnVIP.OnHoverBorderColor = System.Drawing.Color.SandyBrown;
            this.btnVIP.OnHoverForeColor = System.Drawing.Color.White;
            this.btnVIP.OnHoverImage = null;
            this.btnVIP.OnPressedColor = System.Drawing.Color.Peru;
            this.btnVIP.Radius = 5;
            this.btnVIP.Size = new System.Drawing.Size(154, 152);
            this.btnVIP.TabIndex = 3;
            this.btnVIP.Text = "VIP";
            this.btnVIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnVVIP
            // 
            this.btnVVIP.AnimationHoverSpeed = 0.07F;
            this.btnVVIP.AnimationSpeed = 0.03F;
            this.btnVVIP.BackColor = System.Drawing.Color.Transparent;
            this.btnVVIP.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVVIP.BorderColor = System.Drawing.Color.Black;
            this.gunaTransition1.SetDecoration(this.btnVVIP, Guna.UI.Animation.DecorationType.None);
            this.btnVVIP.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVVIP.ForeColor = System.Drawing.Color.White;
            this.btnVVIP.Image = null;
            this.btnVVIP.ImageSize = new System.Drawing.Size(20, 20);
            this.btnVVIP.Location = new System.Drawing.Point(616, 271);
            this.btnVVIP.Name = "btnVVIP";
            this.btnVVIP.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnVVIP.OnHoverBorderColor = System.Drawing.Color.SandyBrown;
            this.btnVVIP.OnHoverForeColor = System.Drawing.Color.White;
            this.btnVVIP.OnHoverImage = null;
            this.btnVVIP.OnPressedColor = System.Drawing.Color.Peru;
            this.btnVVIP.Radius = 5;
            this.btnVVIP.Size = new System.Drawing.Size(154, 152);
            this.btnVVIP.TabIndex = 4;
            this.btnVVIP.Text = "VVIP";
            this.btnVVIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaTransfarantPictureBox1
            // 
            this.gunaTransfarantPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTransfarantPictureBox1.BaseColor = System.Drawing.Color.Black;
            this.gunaTransition1.SetDecoration(this.gunaTransfarantPictureBox1, Guna.UI.Animation.DecorationType.None);
            this.gunaTransfarantPictureBox1.Image = global::HotelAlexa.Properties.Resources.Group_6;
            this.gunaTransfarantPictureBox1.Location = new System.Drawing.Point(395, 104);
            this.gunaTransfarantPictureBox1.Name = "gunaTransfarantPictureBox1";
            this.gunaTransfarantPictureBox1.Size = new System.Drawing.Size(154, 136);
            this.gunaTransfarantPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaTransfarantPictureBox1.TabIndex = 5;
            this.gunaTransfarantPictureBox1.TabStop = false;
            // 
            // gunaTransition1
            // 
            this.gunaTransition1.AnimationType = Guna.UI.Animation.AnimationType.VertSlide;
            this.gunaTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.gunaTransition1.DefaultAnimation = animation1;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(931, 457);
            this.Controls.Add(this.gunaTransfarantPictureBox1);
            this.Controls.Add(this.btnVVIP);
            this.Controls.Add(this.btnVIP);
            this.Controls.Add(this.btnReguler);
            this.Controls.Add(this.gunaLabel1);
            this.gunaTransition1.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.DoubleBuffered = true;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton btnReguler;
        private Guna.UI.WinForms.GunaButton btnVIP;
        private Guna.UI.WinForms.GunaButton btnVVIP;
        private Guna.UI.WinForms.GunaTransfarantPictureBox gunaTransfarantPictureBox1;
        private Guna.UI.WinForms.GunaTransition gunaTransition1;
    }
}

