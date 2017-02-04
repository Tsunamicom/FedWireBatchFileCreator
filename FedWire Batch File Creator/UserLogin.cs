using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FedWire_Batch_File_Creator
{
    public partial class UserLogin : Form
    {
        public UserAccess currentUserSession = new UserAccess();

        public UserLogin()
        {
            InitializeComponent();
        }

        private void userNameTextBox_Enter(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == "User Name")
            {
                userNameTextBox.Text = null;
            }
        }

        private void userNameTextBox_Leave(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == "")
            {
                userNameTextBox.Text = "User Name";
                userNameTextBox.ForeColor = Color.LightGray;
            }
        }

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {
            userNameTextBox.ForeColor = Color.Black;
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordTextBox.ForeColor = Color.Black;
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "Password")
            {
                passwordTextBox.Text = null;
            }
        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "")
            {
                passwordTextBox.Text = "Password";
                passwordTextBox.ForeColor = Color.LightGray;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.Text != "Password" && userNameTextBox.Text != "User Name")
            {

                currentUserSession.thisUser.UserName = userNameTextBox.Text;
                currentUserSession.thisUser.Password = passwordTextBox.Text;
                using (FWFCUsersdbEntities context = new FWFCUsersdbEntities())
                {
                    if (context.Users.Any(c => c.UserName == currentUserSession.thisUser.UserName))
                    {
                        var thisUser = context.Users.Where(c => c.UserName == currentUserSession.thisUser.UserName).FirstOrDefault();

                        if (thisUser.Password == currentUserSession.thisUser.Password)
                        {
                            thisUser.UserStatus = "LOGGEDIN";
                            thisUser.LastAccessDateTime = DateTime.Now;
                            currentUserSession.thisUser.First_Name = thisUser.First_Name;
                            currentUserSession.thisUser.Last_Name = thisUser.Last_Name;
                        }
                        context.SaveChanges();
                        MessageBox.Show($"User Logging In!\n{currentUserSession.thisUser.First_Name}\n{currentUserSession.thisUser.Last_Name}");
                    }
                }
            }
        }
    }
}
