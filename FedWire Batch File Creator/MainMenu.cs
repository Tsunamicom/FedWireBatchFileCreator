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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openNewDomesticWireButton_Click(object sender, EventArgs e)
        {
            Form newDomesticWire = new DomesticWireFrm();
            newDomesticWire.ShowDialog();
        }
    }
}
