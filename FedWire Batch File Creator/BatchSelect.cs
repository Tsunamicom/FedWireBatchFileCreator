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
    public partial class BatchSelect : Form
    {
        public int SelectedBatchID;

        public BatchSelect()
        {
            InitializeComponent();
        }

        private void BatchSelect_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fWFCdbDataSetViews.BatchSummary' table. You can move, or remove it, as needed.
            this.batchSummaryTableAdapter.Fill(this.fWFCdbDataSetViews.BatchSummary);

        }

        private void dataGridViewBatchSummarySelection_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewBatchSummarySelection.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridViewBatchSummarySelection.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewBatchSummarySelection.Rows[selectedrowindex];
                SelectedBatchID = int.Parse(selectedRow.Cells[0].Value.ToString());
                Debug.WriteLine("BATCHSELECT:  SelectedBatch is now Batch #: " + SelectedBatchID);
                Close();
            }
        }
    }
}
