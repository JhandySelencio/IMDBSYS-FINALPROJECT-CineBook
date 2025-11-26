namespace IMDBSYS_CineBook
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.descLBL = new System.Windows.Forms.Label();
            this.emailTXTBOX = new System.Windows.Forms.TextBox();
            this.roleCMBBOX = new System.Windows.Forms.ComboBox();
            this.phoneNoTXTBOX = new System.Windows.Forms.TextBox();
            this.fullnameTXTBOX = new System.Windows.Forms.TextBox();
            this.roleLBL = new System.Windows.Forms.Label();
            this.phoneNoLBL = new System.Windows.Forms.Label();
            this.emailLBL = new System.Windows.Forms.Label();
            this.headDisplayLBL = new System.Windows.Forms.Label();
            this.fullNameLBL = new System.Windows.Forms.Label();
            this.registerBTN = new System.Windows.Forms.Button();
            this.passwordTXTBOX = new System.Windows.Forms.TextBox();
            this.passwordLBL = new System.Windows.Forms.Label();
            this.usernameTXTBOX = new System.Windows.Forms.TextBox();
            this.usernameLBL = new System.Windows.Forms.Label();
            this.registerGRPBOX = new System.Windows.Forms.GroupBox();
            this.showPassCHK = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.registerGRPBOX.SuspendLayout();
            this.SuspendLayout();
            // 
            // descLBL
            // 
            this.descLBL.BackColor = System.Drawing.Color.Transparent;
            this.descLBL.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descLBL.ForeColor = System.Drawing.Color.Silver;
            this.descLBL.Location = new System.Drawing.Point(37, 90);
            this.descLBL.Name = "descLBL";
            this.descLBL.Size = new System.Drawing.Size(353, 46);
            this.descLBL.TabIndex = 14;
            this.descLBL.Text = "Welcome fellow New User! Please fill up this form in order to continue.\r\n\r\n\r\n";
            this.descLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emailTXTBOX
            // 
            this.emailTXTBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.emailTXTBOX.Location = new System.Drawing.Point(153, 193);
            this.emailTXTBOX.Name = "emailTXTBOX";
            this.emailTXTBOX.Size = new System.Drawing.Size(187, 26);
            this.emailTXTBOX.TabIndex = 16;
            // 
            // roleCMBBOX
            // 
            this.roleCMBBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleCMBBOX.FormattingEnabled = true;
            this.roleCMBBOX.Location = new System.Drawing.Point(153, 297);
            this.roleCMBBOX.Name = "roleCMBBOX";
            this.roleCMBBOX.Size = new System.Drawing.Size(187, 28);
            this.roleCMBBOX.TabIndex = 15;
            this.roleCMBBOX.Enter += new System.EventHandler(this.roleCMBBOX_Enter);
            // 
            // phoneNoTXTBOX
            // 
            this.phoneNoTXTBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.phoneNoTXTBOX.Location = new System.Drawing.Point(153, 244);
            this.phoneNoTXTBOX.Name = "phoneNoTXTBOX";
            this.phoneNoTXTBOX.Size = new System.Drawing.Size(187, 26);
            this.phoneNoTXTBOX.TabIndex = 14;
            // 
            // fullnameTXTBOX
            // 
            this.fullnameTXTBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fullnameTXTBOX.Location = new System.Drawing.Point(153, 140);
            this.fullnameTXTBOX.Name = "fullnameTXTBOX";
            this.fullnameTXTBOX.Size = new System.Drawing.Size(187, 26);
            this.fullnameTXTBOX.TabIndex = 12;
            // 
            // roleLBL
            // 
            this.roleLBL.AutoSize = true;
            this.roleLBL.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.roleLBL.Location = new System.Drawing.Point(29, 303);
            this.roleLBL.Name = "roleLBL";
            this.roleLBL.Size = new System.Drawing.Size(121, 22);
            this.roleLBL.TabIndex = 11;
            this.roleLBL.Text = "Register as:";
            // 
            // phoneNoLBL
            // 
            this.phoneNoLBL.AutoSize = true;
            this.phoneNoLBL.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.phoneNoLBL.Location = new System.Drawing.Point(32, 248);
            this.phoneNoLBL.Name = "phoneNoLBL";
            this.phoneNoLBL.Size = new System.Drawing.Size(118, 22);
            this.phoneNoLBL.TabIndex = 10;
            this.phoneNoLBL.Text = "Phone No#:";
            // 
            // emailLBL
            // 
            this.emailLBL.AutoSize = true;
            this.emailLBL.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.emailLBL.Location = new System.Drawing.Point(79, 193);
            this.emailLBL.Name = "emailLBL";
            this.emailLBL.Size = new System.Drawing.Size(68, 22);
            this.emailLBL.TabIndex = 9;
            this.emailLBL.Text = "Email:";
            // 
            // headDisplayLBL
            // 
            this.headDisplayLBL.AutoSize = true;
            this.headDisplayLBL.BackColor = System.Drawing.Color.Transparent;
            this.headDisplayLBL.Font = new System.Drawing.Font("Arial", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headDisplayLBL.ForeColor = System.Drawing.Color.White;
            this.headDisplayLBL.Location = new System.Drawing.Point(59, 27);
            this.headDisplayLBL.Name = "headDisplayLBL";
            this.headDisplayLBL.Size = new System.Drawing.Size(313, 51);
            this.headDisplayLBL.TabIndex = 13;
            this.headDisplayLBL.Text = "Regsiter Form";
            // 
            // fullNameLBL
            // 
            this.fullNameLBL.AutoSize = true;
            this.fullNameLBL.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.fullNameLBL.Location = new System.Drawing.Point(42, 141);
            this.fullNameLBL.Name = "fullNameLBL";
            this.fullNameLBL.Size = new System.Drawing.Size(108, 22);
            this.fullNameLBL.TabIndex = 8;
            this.fullNameLBL.Text = "Full Name:";
            // 
            // registerBTN
            // 
            this.registerBTN.BackColor = System.Drawing.Color.Red;
            this.registerBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registerBTN.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBTN.Location = new System.Drawing.Point(97, 379);
            this.registerBTN.Name = "registerBTN";
            this.registerBTN.Size = new System.Drawing.Size(206, 43);
            this.registerBTN.TabIndex = 4;
            this.registerBTN.Text = "Register";
            this.registerBTN.UseVisualStyleBackColor = false;
            this.registerBTN.Click += new System.EventHandler(this.registerBTN_Click);
            // 
            // passwordTXTBOX
            // 
            this.passwordTXTBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.passwordTXTBOX.Location = new System.Drawing.Point(153, 85);
            this.passwordTXTBOX.Name = "passwordTXTBOX";
            this.passwordTXTBOX.Size = new System.Drawing.Size(187, 26);
            this.passwordTXTBOX.TabIndex = 3;
            this.passwordTXTBOX.UseSystemPasswordChar = true;
            // 
            // passwordLBL
            // 
            this.passwordLBL.AutoSize = true;
            this.passwordLBL.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.passwordLBL.ForeColor = System.Drawing.Color.White;
            this.passwordLBL.Location = new System.Drawing.Point(40, 86);
            this.passwordLBL.Name = "passwordLBL";
            this.passwordLBL.Size = new System.Drawing.Size(110, 22);
            this.passwordLBL.TabIndex = 2;
            this.passwordLBL.Text = "Password:";
            // 
            // usernameTXTBOX
            // 
            this.usernameTXTBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.usernameTXTBOX.Location = new System.Drawing.Point(153, 35);
            this.usernameTXTBOX.Name = "usernameTXTBOX";
            this.usernameTXTBOX.Size = new System.Drawing.Size(187, 26);
            this.usernameTXTBOX.TabIndex = 1;
            // 
            // usernameLBL
            // 
            this.usernameLBL.AutoSize = true;
            this.usernameLBL.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLBL.ForeColor = System.Drawing.Color.White;
            this.usernameLBL.Location = new System.Drawing.Point(42, 36);
            this.usernameLBL.Name = "usernameLBL";
            this.usernameLBL.Size = new System.Drawing.Size(111, 22);
            this.usernameLBL.TabIndex = 0;
            this.usernameLBL.Text = "Username:";
            // 
            // registerGRPBOX
            // 
            this.registerGRPBOX.Controls.Add(this.showPassCHK);
            this.registerGRPBOX.Controls.Add(this.emailTXTBOX);
            this.registerGRPBOX.Controls.Add(this.roleCMBBOX);
            this.registerGRPBOX.Controls.Add(this.phoneNoTXTBOX);
            this.registerGRPBOX.Controls.Add(this.fullnameTXTBOX);
            this.registerGRPBOX.Controls.Add(this.roleLBL);
            this.registerGRPBOX.Controls.Add(this.phoneNoLBL);
            this.registerGRPBOX.Controls.Add(this.emailLBL);
            this.registerGRPBOX.Controls.Add(this.fullNameLBL);
            this.registerGRPBOX.Controls.Add(this.registerBTN);
            this.registerGRPBOX.Controls.Add(this.passwordTXTBOX);
            this.registerGRPBOX.Controls.Add(this.passwordLBL);
            this.registerGRPBOX.Controls.Add(this.usernameTXTBOX);
            this.registerGRPBOX.Controls.Add(this.usernameLBL);
            this.registerGRPBOX.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.registerGRPBOX.Location = new System.Drawing.Point(25, 139);
            this.registerGRPBOX.Name = "registerGRPBOX";
            this.registerGRPBOX.Size = new System.Drawing.Size(390, 453);
            this.registerGRPBOX.TabIndex = 12;
            this.registerGRPBOX.TabStop = false;
            // 
            // showPassCHK
            // 
            this.showPassCHK.AutoSize = true;
            this.showPassCHK.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.showPassCHK.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPassCHK.Location = new System.Drawing.Point(227, 117);
            this.showPassCHK.Name = "showPassCHK";
            this.showPassCHK.Size = new System.Drawing.Size(113, 17);
            this.showPassCHK.TabIndex = 17;
            this.showPassCHK.Text = "Show Password";
            this.showPassCHK.UseVisualStyleBackColor = true;
            this.showPassCHK.CheckedChanged += new System.EventHandler(this.showPassCHK_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 42F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 74);
            this.label1.TabIndex = 16;
            this.label1.Text = "                       ";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(440, 608);
            this.Controls.Add(this.descLBL);
            this.Controls.Add(this.headDisplayLBL);
            this.Controls.Add(this.registerGRPBOX);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterForm";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.registerGRPBOX.ResumeLayout(false);
            this.registerGRPBOX.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label descLBL;
        private System.Windows.Forms.TextBox emailTXTBOX;
        private System.Windows.Forms.ComboBox roleCMBBOX;
        private System.Windows.Forms.TextBox phoneNoTXTBOX;
        private System.Windows.Forms.TextBox fullnameTXTBOX;
        private System.Windows.Forms.Label roleLBL;
        private System.Windows.Forms.Label phoneNoLBL;
        private System.Windows.Forms.Label emailLBL;
        private System.Windows.Forms.Label headDisplayLBL;
        private System.Windows.Forms.Label fullNameLBL;
        private System.Windows.Forms.Button registerBTN;
        private System.Windows.Forms.TextBox passwordTXTBOX;
        private System.Windows.Forms.Label passwordLBL;
        private System.Windows.Forms.TextBox usernameTXTBOX;
        private System.Windows.Forms.Label usernameLBL;
        private System.Windows.Forms.GroupBox registerGRPBOX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox showPassCHK;
    }
}