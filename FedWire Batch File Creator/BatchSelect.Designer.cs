namespace FedWire_Batch_File_Creator
{
    partial class BatchSelect
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewBatchSummarySelection = new System.Windows.Forms.DataGridView();
            this.fWFCdbDataSetViews = new FedWire_Batch_File_Creator.FWFCdbDataSetViews();
            this.batchSummaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.batchSummaryTableAdapter = new FedWire_Batch_File_Creator.FWFCdbDataSetViewsTableAdapters.BatchSummaryTableAdapter();
            this.batchIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalWireAmtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfWiresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openedTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openedUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oFACVerifiedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBatchSummarySelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fWFCdbDataSetViews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batchSummaryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBatchSummarySelection
            // 
            this.dataGridViewBatchSummarySelection.AllowUserToAddRows = false;
            this.dataGridViewBatchSummarySelection.AllowUserToDeleteRows = false;
            this.dataGridViewBatchSummarySelection.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridViewBatchSummarySelection.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBatchSummarySelection.AutoGenerateColumns = false;
            this.dataGridViewBatchSummarySelection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBatchSummarySelection.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.batchIDDataGridViewTextBoxColumn,
            this.totalWireAmtDataGridViewTextBoxColumn,
            this.numberOfWiresDataGridViewTextBoxColumn,
            this.openedTimeDataGridViewTextBoxColumn,
            this.openedUserDataGridViewTextBoxColumn,
            this.oFACVerifiedDataGridViewCheckBoxColumn});
            this.dataGridViewBatchSummarySelection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewBatchSummarySelection.DataSource = this.batchSummaryBindingSource;
            this.dataGridViewBatchSummarySelection.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewBatchSummarySelection.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewBatchSummarySelection.Location = new System.Drawing.Point(0, 22);
            this.dataGridViewBatchSummarySelection.MultiSelect = false;
            this.dataGridViewBatchSummarySelection.Name = "dataGridViewBatchSummarySelection";
            this.dataGridViewBatchSummarySelection.ReadOnly = true;
            this.dataGridViewBatchSummarySelection.RowHeadersVisible = false;
            this.dataGridViewBatchSummarySelection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBatchSummarySelection.Size = new System.Drawing.Size(699, 150);
            this.dataGridViewBatchSummarySelection.TabIndex = 0;
            this.dataGridViewBatchSummarySelection.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBatchSummarySelection_CellDoubleClick);
            // 
            // fWFCdbDataSetViews
            // 
            this.fWFCdbDataSetViews.DataSetName = "FWFCdbDataSetViews";
            this.fWFCdbDataSetViews.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // batchSummaryBindingSource
            // 
            this.batchSummaryBindingSource.DataMember = "BatchSummary";
            this.batchSummaryBindingSource.DataSource = this.fWFCdbDataSetViews;
            // 
            // batchSummaryTableAdapter
            // 
            this.batchSummaryTableAdapter.ClearBeforeFill = true;
            // 
            // batchIDDataGridViewTextBoxColumn
            // 
            this.batchIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.batchIDDataGridViewTextBoxColumn.DataPropertyName = "BatchID";
            this.batchIDDataGridViewTextBoxColumn.HeaderText = "BatchID";
            this.batchIDDataGridViewTextBoxColumn.Name = "batchIDDataGridViewTextBoxColumn";
            this.batchIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.batchIDDataGridViewTextBoxColumn.Width = 71;
            // 
            // totalWireAmtDataGridViewTextBoxColumn
            // 
            this.totalWireAmtDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.totalWireAmtDataGridViewTextBoxColumn.DataPropertyName = "Total Wire Amt";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.totalWireAmtDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.totalWireAmtDataGridViewTextBoxColumn.HeaderText = "Total Wire Amt";
            this.totalWireAmtDataGridViewTextBoxColumn.Name = "totalWireAmtDataGridViewTextBoxColumn";
            this.totalWireAmtDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalWireAmtDataGridViewTextBoxColumn.Width = 78;
            // 
            // numberOfWiresDataGridViewTextBoxColumn
            // 
            this.numberOfWiresDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.numberOfWiresDataGridViewTextBoxColumn.DataPropertyName = "Number of Wires";
            this.numberOfWiresDataGridViewTextBoxColumn.HeaderText = "Number of Wires";
            this.numberOfWiresDataGridViewTextBoxColumn.Name = "numberOfWiresDataGridViewTextBoxColumn";
            this.numberOfWiresDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberOfWiresDataGridViewTextBoxColumn.Width = 78;
            // 
            // openedTimeDataGridViewTextBoxColumn
            // 
            this.openedTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.openedTimeDataGridViewTextBoxColumn.DataPropertyName = "Opened_Time";
            dataGridViewCellStyle3.Format = "g";
            dataGridViewCellStyle3.NullValue = null;
            this.openedTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.openedTimeDataGridViewTextBoxColumn.HeaderText = "Opened_Time";
            this.openedTimeDataGridViewTextBoxColumn.Name = "openedTimeDataGridViewTextBoxColumn";
            this.openedTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.openedTimeDataGridViewTextBoxColumn.Width = 99;
            // 
            // openedUserDataGridViewTextBoxColumn
            // 
            this.openedUserDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.openedUserDataGridViewTextBoxColumn.DataPropertyName = "Opened_User";
            this.openedUserDataGridViewTextBoxColumn.HeaderText = "Opened_User";
            this.openedUserDataGridViewTextBoxColumn.Name = "openedUserDataGridViewTextBoxColumn";
            this.openedUserDataGridViewTextBoxColumn.ReadOnly = true;
            this.openedUserDataGridViewTextBoxColumn.Width = 98;
            // 
            // oFACVerifiedDataGridViewCheckBoxColumn
            // 
            this.oFACVerifiedDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.oFACVerifiedDataGridViewCheckBoxColumn.DataPropertyName = "OFAC_Verified";
            this.oFACVerifiedDataGridViewCheckBoxColumn.HeaderText = "OFAC_Verified";
            this.oFACVerifiedDataGridViewCheckBoxColumn.Name = "oFACVerifiedDataGridViewCheckBoxColumn";
            this.oFACVerifiedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // BatchSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 172);
            this.Controls.Add(this.dataGridViewBatchSummarySelection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "BatchSelect";
            this.Text = "BatchSelect";
            this.Load += new System.EventHandler(this.BatchSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBatchSummarySelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fWFCdbDataSetViews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batchSummaryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBatchSummarySelection;
        private FWFCdbDataSetViews fWFCdbDataSetViews;
        private System.Windows.Forms.BindingSource batchSummaryBindingSource;
        private FWFCdbDataSetViewsTableAdapters.BatchSummaryTableAdapter batchSummaryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalWireAmtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfWiresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openedTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openedUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn oFACVerifiedDataGridViewCheckBoxColumn;
    }
}