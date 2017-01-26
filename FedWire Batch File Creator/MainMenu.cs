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
            startNewBatch();
            InitializeComponent();
        }

        private void startNewBatch()
        {
            using (var currentBatch = new FWFCdbEntities())
            {
                Batch newbatch = currentBatch.Batches.Add(new Batch
                {
                    Opened_Time = DateTime.Now,
                    Opened_User = "Test User",
                    OFAC_Verified = false
                });
                currentBatch.SaveChanges();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openNewDomesticWireButton_Click(object sender, EventArgs e)
        {
            Form newDomesticWire = new DomesticWireFrm();
            newDomesticWire.ShowDialog();
        }

        private void domesticWireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form newDomesticWire = new DomesticWireFrm();
            newDomesticWire.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult confirmExit = MessageBox.Show("Confirm Exit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(confirmExit.Equals(DialogResult.OK))
            {
                Application.Exit();
            }
        }
    }
}
