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
    public partial class LoginForm : Form
    {
        WelcomeForm welcomeForm = new WelcomeForm();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBTN_Click(object sender, EventArgs e) //Change this login part
        {
            if (string.IsNullOrWhiteSpace(usernameTXTBOX.Text) ||
                string.IsNullOrWhiteSpace(passwordTXTBOX.Text) )
            {
                MessageBox.Show("Please fill in all the fields before logging in.",
                                "Warning Empty Fields", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            using (var db = new CineBookDBEntities())
            {
                var user = db.Users.FirstOrDefault(u => u.Username == usernameTXTBOX.Text &&
                                                        u.Password == passwordTXTBOX.Text);          

                if (user != null)
                {
                    if (user.RoleID == 1 && user.StatusID == 1)
                    {
                        MessageBox.Show("You have successfully logged in.", "Login Sucessful",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //  Insert Admin Form
                    }
                    else if (user.RoleID == 1 && user.StatusID == 3)
                    {
                        MessageBox.Show("Please wait while we verify your admin account application.", "Pending for Approval",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else if (user.RoleID == 2)
                    {
                        MessageBox.Show("You have successfully logged in.", "Login Sucessful",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DashboardForm dashboardForm = new DashboardForm(user.Fullname, user.UserID);
                        dashboardForm.Show();
                    }
                        this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Login Failed",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoginForm_ControlRemoved(object sender, ControlEventArgs e)
        {

        }

        private void showPassCHK_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassCHK.Checked)
            {
                passwordTXTBOX.UseSystemPasswordChar = false;
            }
            else 
            {
                passwordTXTBOX.UseSystemPasswordChar = true;
            }
        }
    }
}
