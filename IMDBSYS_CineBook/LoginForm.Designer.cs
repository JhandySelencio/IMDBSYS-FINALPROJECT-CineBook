namespace IMDBSYS_CineBook
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.headDisplayLBL = new System.Windows.Forms.Label();
            this.loginGRPBOX = new System.Windows.Forms.GroupBox();
            this.showPassCHK = new System.Windows.Forms.CheckBox();
            this.loginBTN = new System.Windows.Forms.Button();
            this.passwordTXTBOX = new System.Windows.Forms.TextBox();
            this.passwordLBL = new System.Windows.Forms.Label();
            this.usernameTXTBOX = new System.Windows.Forms.TextBox();
            this.usernameLBL = new System.Windows.Forms.Label();
            this.descLBL = new System.Windows.Forms.Label();
            this.borderLBL = new System.Windows.Forms.Label();
            this.loginGRPBOX.SuspendLayout();
            this.SuspendLayout();
            // 
            // headDisplayLBL
            // 
            this.headDisplayLBL.AutoSize = true;
            this.headDisplayLBL.BackColor = System.Drawing.Color.Transparent;
            this.headDisplayLBL.Font = new System.Drawing.Font("Arial", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headDisplayLBL.ForeColor = System.Drawing.Color.White;
            this.headDisplayLBL.Location = new System.Drawing.Point(90, 26);
            this.headDisplayLBL.Name = "headDisplayLBL";
            this.headDisplayLBL.Size = new System.Drawing.Size(257, 51);
            this.headDisplayLBL.TabIndex = 14;
            this.headDisplayLBL.Text = "Login Form";
            // 
            // loginGRPBOX
            // 
            this.loginGRPBOX.Controls.Add(this.showPassCHK);
            this.loginGRPBOX.Controls.Add(this.loginBTN);
            this.loginGRPBOX.Controls.Add(this.passwordTXTBOX);
            this.loginGRPBOX.Controls.Add(this.passwordLBL);
            this.loginGRPBOX.Controls.Add(this.usernameTXTBOX);
            this.loginGRPBOX.Controls.Add(this.usernameLBL);
            this.loginGRPBOX.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.loginGRPBOX.Location = new System.Drawing.Point(25, 138);
            this.loginGRPBOX.Name = "loginGRPBOX";
            this.loginGRPBOX.Size = new System.Drawing.Size(390, 308);
            this.loginGRPBOX.TabIndex = 13;
            this.loginGRPBOX.TabStop = false;
            // 
            // showPassCHK
            // 
            this.showPassCHK.AutoSize = true;
            this.showPassCHK.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.showPassCHK.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPassCHK.Location = new System.Drawing.Point(234, 167);
            this.showPassCHK.Name = "showPassCHK";
            this.showPassCHK.Size = new System.Drawing.Size(113, 17);
            this.showPassCHK.TabIndex = 18;
            this.showPassCHK.Text = "Show Password";
            this.showPassCHK.UseVisualStyleBackColor = true;
            this.showPassCHK.CheckedChanged += new System.EventHandler(this.showPassCHK_CheckedChanged);
            // 
            // loginBTN
            // 
            this.loginBTN.BackColor = System.Drawing.Color.Red;
            this.loginBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginBTN.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBTN.Location = new System.Drawing.Point(95, 198);
            this.loginBTN.Name = "loginBTN";
            this.loginBTN.Size = new System.Drawing.Size(206, 43);
            this.loginBTN.TabIndex = 7;
            this.loginBTN.Text = "Login";
            this.loginBTN.UseVisualStyleBackColor = false;
            this.loginBTN.Click += new System.EventHandler(this.loginBTN_Click);
            // 
            // passwordTXTBOX
            // 
            this.passwordTXTBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.passwordTXTBOX.Location = new System.Drawing.Point(160, 130);
            this.passwordTXTBOX.Name = "passwordTXTBOX";
            this.passwordTXTBOX.Size = new System.Drawing.Size(187, 31);
            this.passwordTXTBOX.TabIndex = 3;
            this.passwordTXTBOX.UseSystemPasswordChar = true;
            // 
            // passwordLBL
            // 
            this.passwordLBL.AutoSize = true;
            this.passwordLBL.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.passwordLBL.ForeColor = System.Drawing.Color.White;
            this.passwordLBL.Location = new System.Drawing.Point(38, 134);
            this.passwordLBL.Name = "passwordLBL";
            this.passwordLBL.Size = new System.Drawing.Size(116, 24);
            this.passwordLBL.TabIndex = 2;
            this.passwordLBL.Text = "Password:";
            // 
            // usernameTXTBOX
            // 
            this.usernameTXTBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTXTBOX.Location = new System.Drawing.Point(160, 71);
            this.usernameTXTBOX.Name = "usernameTXTBOX";
            this.usernameTXTBOX.Size = new System.Drawing.Size(187, 31);
            this.usernameTXTBOX.TabIndex = 1;
            // 
            // usernameLBL
            // 
            this.usernameLBL.AutoSize = true;
            this.usernameLBL.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLBL.ForeColor = System.Drawing.Color.White;
            this.usernameLBL.Location = new System.Drawing.Point(35, 75);
            this.usernameLBL.Name = "usernameLBL";
            this.usernameLBL.Size = new System.Drawing.Size(119, 24);
            this.usernameLBL.TabIndex = 0;
            this.usernameLBL.Text = "Username:";
            // 
            // descLBL
            // 
            this.descLBL.BackColor = System.Drawing.Color.Transparent;
            this.descLBL.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descLBL.ForeColor = System.Drawing.Color.Silver;
            this.descLBL.Location = new System.Drawing.Point(38, 89);
            this.descLBL.Name = "descLBL";
            this.descLBL.Size = new System.Drawing.Size(353, 46);
            this.descLBL.TabIndex = 12;
            this.descLBL.Text = "Hey, Welcome Back! Please enter your correct credentials inorder to login.\r\n\r\n";
            this.descLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // borderLBL
            // 
            this.borderLBL.AutoSize = true;
            this.borderLBL.BackColor = System.Drawing.Color.Transparent;
            this.borderLBL.Font = new System.Drawing.Font("Segoe UI", 42F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.borderLBL.ForeColor = System.Drawing.Color.White;
            this.borderLBL.Location = new System.Drawing.Point(29, 15);
            this.borderLBL.Name = "borderLBL";
            this.borderLBL.Size = new System.Drawing.Size(377, 74);
            this.borderLBL.TabIndex = 15;
            this.borderLBL.Text = "                       ";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(440, 460);
            this.Controls.Add(this.headDisplayLBL);
            this.Controls.Add(this.loginGRPBOX);
            this.Controls.Add(this.descLBL);
            this.Controls.Add(this.borderLBL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.LoginForm_ControlRemoved);
            this.loginGRPBOX.ResumeLayout(false);
            this.loginGRPBOX.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headDisplayLBL;
        private System.Windows.Forms.GroupBox loginGRPBOX;
        private System.Windows.Forms.Button loginBTN;
        private System.Windows.Forms.TextBox passwordTXTBOX;
        private System.Windows.Forms.Label passwordLBL;
        private System.Windows.Forms.TextBox usernameTXTBOX;
        private System.Windows.Forms.Label usernameLBL;
        private System.Windows.Forms.Label descLBL;
        private System.Windows.Forms.Label borderLBL;
        private System.Windows.Forms.CheckBox showPassCHK;
    }
}