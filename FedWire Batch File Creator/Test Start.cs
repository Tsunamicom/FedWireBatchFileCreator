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
    public partial class Test_Start : Form
    {
        public Test_Start()
        {
            InitializeComponent();
        }

        private void tsDomesticWireForm_Click(object sender, EventArgs e)
        {
            DomesticWireForm tsDWForm = new DomesticWireForm();
            tsDWForm.ShowDialog();
        }

        private void tsLoginForm_Click(object sender, EventArgs e)
        {
            UserLogin tsULForm = new UserLogin();
            tsULForm.ShowDialog();
        }
    }
}
