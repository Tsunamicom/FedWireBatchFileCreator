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
    public partial class Test_Start : Form
    {
        public UserAccess UserSession = new UserAccess();

        public Test_Start()
        {
            InitializeComponent();
        }

        private void tsDomesticWireForm_Click(object sender, EventArgs e)
        {
            DomesticWireForm tsDWForm = new DomesticWireForm(UserSession);
            tsDWForm.ShowDialog();
        }

        private void tsLoginForm_Click(object sender, EventArgs e)
        {
            UserLogin tsULForm = new UserLogin();
            tsULForm.ShowDialog();
            UserSession = tsULForm.currentUserSession;
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            if (!(UserSession.thisUser.UserName == null))
            {
                Debug.WriteLine("Closing User Session: " + UserSession.thisUser.UserName);
                UserSession.LogOut();
            }
            
        }
    }
}
