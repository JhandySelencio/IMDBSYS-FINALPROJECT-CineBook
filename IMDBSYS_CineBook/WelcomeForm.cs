using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMDBSYS_CineBook
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginBTN.Enabled = false;
            registerBTN.Enabled = false;
            loginForm.FormClosed += (s, args) => loginBTN.Enabled = true;
            loginForm.FormClosed += (s, args) => registerBTN.Enabled = true;
            loginForm.Show();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            loginBTN.Enabled = true;
            registerBTN.Enabled = true;
        }

        private void registerBTN_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            loginBTN.Enabled = false;
            registerBTN.Enabled = false;
            registerForm.FormClosed += (s, args) => loginBTN.Enabled = true;
            registerForm.FormClosed += (s, args) => registerBTN.Enabled = true;
            registerForm.Show();
        }
    }
}
