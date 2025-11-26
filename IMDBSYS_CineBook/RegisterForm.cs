using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IMDBSYS_CineBook
{
    public partial class RegisterForm : Form
    {
        private static CineBookDBEntities database = new CineBookDBEntities();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            usernameTXTBOX.Clear();
            passwordTXTBOX.Clear();
            fullnameTXTBOX.Clear();
            phoneNoTXTBOX.Clear();
            LoadRoles();
        }

        private void LoadRoles()
        // Populates the Role combo box
        {
            using (var db = new CineBookDBEntities())
            {
                var roles = db.Roles.ToList();

                roleCMBBOX.DataSource = roles;
                roleCMBBOX.DisplayMember = "RoleTitle";
                roleCMBBOX.ValueMember = "RoleID";
            }  
        }
        
        private void showPassCHK_CheckedChanged(object sender, EventArgs e)
        //  Shows the password
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

        private void registerBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernameTXTBOX.Text) ||
                string.IsNullOrWhiteSpace(passwordTXTBOX.Text) ||
                string.IsNullOrWhiteSpace(fullnameTXTBOX.Text) ||
                string.IsNullOrWhiteSpace(emailTXTBOX.Text) ||
                string.IsNullOrWhiteSpace(phoneNoTXTBOX.Text) ||
                roleCMBBOX.SelectedIndex < 0)
            {
                MessageBox.Show("Please fill in all the fields before registring.", 
                                "Warning Empty Fields", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            using (var db = new CineBookDBEntities()) 
            {
                int roleSelected = roleCMBBOX.SelectedIndex + 1;
                int statusID = 0;

                if (roleSelected == 1) //If Admin selected, status will set to Pending
                {
                    statusID = 3;
                }
                else  //If Customer selectd, status will set to Active 
                {
                    statusID = 1;
                }

                User newUser = new User()
                {
                    Username = usernameTXTBOX.Text,
                    Password = passwordTXTBOX.Text,
                    Fullname = fullnameTXTBOX.Text,
                    Email = emailTXTBOX.Text,
                    PhoneNumber = phoneNoTXTBOX.Text,
                    RoleID = roleSelected,
                    StatusID = statusID,
                };  

                db.Users.Add(newUser);
                db.SaveChanges();

                if (roleSelected == 1)
                {
                    MessageBox.Show("You have successfuly created an Admin account. You have to wait for your account to get accepted by an Admin", "Registered  Successful",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    MessageBox.Show("You have successfuly created an account.", "Registered Successful",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
        }

        private void roleCMBBOX_Enter(object sender, EventArgs e)
        {

        }
    }
}
