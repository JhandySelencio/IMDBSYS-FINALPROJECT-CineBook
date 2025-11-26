namespace IMDBSYS_CineBook
{
    partial class WelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            this.projTitleLBL = new System.Windows.Forms.Label();
            this.borderLBL = new System.Windows.Forms.Label();
            this.logoPICBOX = new System.Windows.Forms.PictureBox();
            this.descLBL = new System.Windows.Forms.Label();
            this.loginBTN = new System.Windows.Forms.Button();
            this.registerBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoPICBOX)).BeginInit();
            this.SuspendLayout();
            // 
            // projTitleLBL
            // 
            this.projTitleLBL.BackColor = System.Drawing.Color.Transparent;
            this.projTitleLBL.Font = new System.Drawing.Font("Microsoft Tai Le", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projTitleLBL.ForeColor = System.Drawing.Color.White;
            this.projTitleLBL.Location = new System.Drawing.Point(261, 119);
            this.projTitleLBL.Name = "projTitleLBL";
            this.projTitleLBL.Size = new System.Drawing.Size(374, 72);
            this.projTitleLBL.TabIndex = 15;
            this.projTitleLBL.Text = "CineBook";
            // 
            // borderLBL
            // 
            this.borderLBL.AutoSize = true;
            this.borderLBL.BackColor = System.Drawing.Color.Transparent;
            this.borderLBL.Font = new System.Drawing.Font("Segoe UI", 42F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.borderLBL.ForeColor = System.Drawing.Color.White;
            this.borderLBL.Location = new System.Drawing.Point(107, 131);
            this.borderLBL.Name = "borderLBL";
            this.borderLBL.Size = new System.Drawing.Size(587, 74);
            this.borderLBL.TabIndex = 16;
            this.borderLBL.Text = "                                     ";
            // 
            // logoPICBOX
            // 
            this.logoPICBOX.BackColor = System.Drawing.Color.Transparent;
            this.logoPICBOX.BackgroundImage = global::IMDBSYS_CineBook.Properties.Resources.film;
            this.logoPICBOX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoPICBOX.Location = new System.Drawing.Point(200, 119);
            this.logoPICBOX.Name = "logoPICBOX";
            this.logoPICBOX.Size = new System.Drawing.Size(68, 65);
            this.logoPICBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPICBOX.TabIndex = 17;
            this.logoPICBOX.TabStop = false;
            // 
            // descLBL
            // 
            this.descLBL.BackColor = System.Drawing.Color.Transparent;
            this.descLBL.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descLBL.ForeColor = System.Drawing.Color.White;
            this.descLBL.Location = new System.Drawing.Point(124, 207);
            this.descLBL.Name = "descLBL";
            this.descLBL.Size = new System.Drawing.Size(555, 60);
            this.descLBL.TabIndex = 18;
            this.descLBL.Text = "A Movie Ticket Booking System where you can Book Popular Movies Online with Ease " +
    "and Style\r\n";
            this.descLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginBTN
            // 
            this.loginBTN.BackColor = System.Drawing.Color.Red;
            this.loginBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginBTN.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F);
            this.loginBTN.ForeColor = System.Drawing.Color.White;
            this.loginBTN.Location = new System.Drawing.Point(318, 289);
            this.loginBTN.Name = "loginBTN";
            this.loginBTN.Size = new System.Drawing.Size(161, 43);
            this.loginBTN.TabIndex = 19;
            this.loginBTN.Text = "Login";
            this.loginBTN.UseVisualStyleBackColor = false;
            this.loginBTN.Click += new System.EventHandler(this.loginBTN_Click);
            // 
            // registerBTN
            // 
            this.registerBTN.BackColor = System.Drawing.Color.Red;
            this.registerBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registerBTN.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F);
            this.registerBTN.ForeColor = System.Drawing.Color.White;
            this.registerBTN.Location = new System.Drawing.Point(318, 354);
            this.registerBTN.Name = "registerBTN";
            this.registerBTN.Size = new System.Drawing.Size(161, 43);
            this.registerBTN.TabIndex = 21;
            this.registerBTN.Text = "Register";
            this.registerBTN.UseVisualStyleBackColor = false;
            this.registerBTN.Click += new System.EventHandler(this.registerBTN_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::IMDBSYS_CineBook.Properties.Resources.CinemaBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(814, 460);
            this.Controls.Add(this.registerBTN);
            this.Controls.Add(this.loginBTN);
            this.Controls.Add(this.logoPICBOX);
            this.Controls.Add(this.projTitleLBL);
            this.Controls.Add(this.descLBL);
            this.Controls.Add(this.borderLBL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WelcomeForm";
            this.Text = "Welcome to CineBook";
            this.Load += new System.EventHandler(this.WelcomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPICBOX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label projTitleLBL;
        private System.Windows.Forms.Label borderLBL;
        private System.Windows.Forms.PictureBox logoPICBOX;
        private System.Windows.Forms.Label descLBL;
        private System.Windows.Forms.Button loginBTN;
        private System.Windows.Forms.Button registerBTN;
    }
}