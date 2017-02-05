using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

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
            else
            {
                userNameTextBox.SelectAll();
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
            else
            {
                passwordTextBox.SelectAll();
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
                currentUserSession.NewUserSession();
                
                if (currentUserSession.thisUser.UserStatus == "LOGGEDIN")
                {
                    Debug.WriteLine(currentUserSession.thisUser.First_Name);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("ERROR!  INVALID USERNAME OR PASSWORD!");
                }
            }
        }

        private void UserLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (currentUserSession.thisUser.UserName == null)
            {
                Application.Exit();
            }

        }
    }
}
