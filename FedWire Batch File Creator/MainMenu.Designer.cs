namespace FedWire_Batch_File_Creator
{
    partial class MainMenu
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
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.domesticWireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalWireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFromTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalWireToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.domesticWireToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.importBatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportBatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oFACCheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.securityQuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutFWFCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openNewDomesticWireButton = new System.Windows.Forms.Button();
            this.openNewInternationalWireButton = new System.Windows.Forms.Button();
            this.openReportsButton = new System.Windows.Forms.Button();
            this.openTemplateButton = new System.Windows.Forms.Button();
            this.batchGridView1 = new System.Windows.Forms.DataGridView();
            this.batchIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openedTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openedUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.submittedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.submittedUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oFACVerifiedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.batchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fWFCdbDataSetBatchFull = new FedWire_Batch_File_Creator.FWFCdbDataSetBatchFull();
            this.fWFCdbDataSet = new FedWire_Batch_File_Creator.FWFCdbDataSet();
            this.fWFCdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.batchTableAdapter = new FedWire_Batch_File_Creator.FWFCdbDataSetBatchFullTableAdapters.BatchTableAdapter();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batchGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fWFCdbDataSetBatchFull)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fWFCdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fWFCdbDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.userOptionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mainMenuStrip.Size = new System.Drawing.Size(702, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.newFromTemplateToolStripMenuItem,
            this.importBatchToolStripMenuItem,
            this.exportBatchToolStripMenuItem,
            this.oFACCheckToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.domesticWireToolStripMenuItem,
            this.internationalWireToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.newToolStripMenuItem.Text = "&New Wire";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // domesticWireToolStripMenuItem
            // 
            this.domesticWireToolStripMenuItem.Name = "domesticWireToolStripMenuItem";
            this.domesticWireToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.domesticWireToolStripMenuItem.Text = "Domestic Wire";
            this.domesticWireToolStripMenuItem.Click += new System.EventHandler(this.domesticWireToolStripMenuItem_Click);
            // 
            // internationalWireToolStripMenuItem
            // 
            this.internationalWireToolStripMenuItem.Name = "internationalWireToolStripMenuItem";
            this.internationalWireToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.internationalWireToolStripMenuItem.Text = "International Wire";
            // 
            // newFromTemplateToolStripMenuItem
            // 
            this.newFromTemplateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.internationalWireToolStripMenuItem1,
            this.domesticWireToolStripMenuItem1});
            this.newFromTemplateToolStripMenuItem.Name = "newFromTemplateToolStripMenuItem";
            this.newFromTemplateToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.newFromTemplateToolStripMenuItem.Text = "&Templates";
            // 
            // internationalWireToolStripMenuItem1
            // 
            this.internationalWireToolStripMenuItem1.Name = "internationalWireToolStripMenuItem1";
            this.internationalWireToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.internationalWireToolStripMenuItem1.Text = "&New";
            // 
            // domesticWireToolStripMenuItem1
            // 
            this.domesticWireToolStripMenuItem1.Name = "domesticWireToolStripMenuItem1";
            this.domesticWireToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.domesticWireToolStripMenuItem1.Text = "&Open";
            // 
            // importBatchToolStripMenuItem
            // 
            this.importBatchToolStripMenuItem.Name = "importBatchToolStripMenuItem";
            this.importBatchToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.importBatchToolStripMenuItem.Text = "&Import Batch";
            // 
            // exportBatchToolStripMenuItem
            // 
            this.exportBatchToolStripMenuItem.Name = "exportBatchToolStripMenuItem";
            this.exportBatchToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.exportBatchToolStripMenuItem.Text = "&Export Batch";
            // 
            // oFACCheckToolStripMenuItem
            // 
            this.oFACCheckToolStripMenuItem.Name = "oFACCheckToolStripMenuItem";
            this.oFACCheckToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.oFACCheckToolStripMenuItem.Text = "&OFAC Verification";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportsToolStripMenuItem,
            this.historyToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.reportsToolStripMenuItem.Text = "&Reports";
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.historyToolStripMenuItem.Text = "&History";
            // 
            // userOptionsToolStripMenuItem
            // 
            this.userOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.securityQuestionsToolStripMenuItem,
            this.logoutToolStripMenuItem1});
            this.userOptionsToolStripMenuItem.Name = "userOptionsToolStripMenuItem";
            this.userOptionsToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.userOptionsToolStripMenuItem.Text = "&User";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.changePasswordToolStripMenuItem.Text = "&Change Password";
            // 
            // securityQuestionsToolStripMenuItem
            // 
            this.securityQuestionsToolStripMenuItem.Name = "securityQuestionsToolStripMenuItem";
            this.securityQuestionsToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.securityQuestionsToolStripMenuItem.Text = "Update &Security Questions";
            // 
            // logoutToolStripMenuItem1
            // 
            this.logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
            this.logoutToolStripMenuItem1.Size = new System.Drawing.Size(213, 22);
            this.logoutToolStripMenuItem1.Text = "&Logout";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.aboutFWFCToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.aboutToolStripMenuItem.Text = "&View Help";
            // 
            // aboutFWFCToolStripMenuItem
            // 
            this.aboutFWFCToolStripMenuItem.Name = "aboutFWFCToolStripMenuItem";
            this.aboutFWFCToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.aboutFWFCToolStripMenuItem.Text = "&About FWFC";
            // 
            // openNewDomesticWireButton
            // 
            this.openNewDomesticWireButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openNewDomesticWireButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.openNewDomesticWireButton.Location = new System.Drawing.Point(12, 39);
            this.openNewDomesticWireButton.Name = "openNewDomesticWireButton";
            this.openNewDomesticWireButton.Size = new System.Drawing.Size(150, 100);
            this.openNewDomesticWireButton.TabIndex = 1;
            this.openNewDomesticWireButton.Text = "DOMESTIC WIRE (BASIC)";
            this.openNewDomesticWireButton.UseVisualStyleBackColor = true;
            this.openNewDomesticWireButton.Click += new System.EventHandler(this.openNewDomesticWireButton_Click);
            // 
            // openNewInternationalWireButton
            // 
            this.openNewInternationalWireButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openNewInternationalWireButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.openNewInternationalWireButton.Enabled = false;
            this.openNewInternationalWireButton.FlatAppearance.BorderSize = 5;
            this.openNewInternationalWireButton.Location = new System.Drawing.Point(187, 39);
            this.openNewInternationalWireButton.Name = "openNewInternationalWireButton";
            this.openNewInternationalWireButton.Size = new System.Drawing.Size(150, 100);
            this.openNewInternationalWireButton.TabIndex = 2;
            this.openNewInternationalWireButton.Text = "INTERNATIONAL WIRE (BASIC - TBD)";
            this.openNewInternationalWireButton.UseVisualStyleBackColor = true;
            // 
            // openReportsButton
            // 
            this.openReportsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openReportsButton.Enabled = false;
            this.openReportsButton.Location = new System.Drawing.Point(362, 39);
            this.openReportsButton.Name = "openReportsButton";
            this.openReportsButton.Size = new System.Drawing.Size(150, 100);
            this.openReportsButton.TabIndex = 3;
            this.openReportsButton.Text = "REPORTS (TBD)";
            this.openReportsButton.UseVisualStyleBackColor = true;
            // 
            // openTemplateButton
            // 
            this.openTemplateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openTemplateButton.Enabled = false;
            this.openTemplateButton.Location = new System.Drawing.Point(541, 39);
            this.openTemplateButton.Name = "openTemplateButton";
            this.openTemplateButton.Size = new System.Drawing.Size(150, 100);
            this.openTemplateButton.TabIndex = 4;
            this.openTemplateButton.Text = "HISTORY (TBD)";
            this.openTemplateButton.UseVisualStyleBackColor = true;
            // 
            // batchGridView1
            // 
            this.batchGridView1.AllowUserToAddRows = false;
            this.batchGridView1.AllowUserToDeleteRows = false;
            this.batchGridView1.AllowUserToResizeColumns = false;
            this.batchGridView1.AllowUserToResizeRows = false;
            this.batchGridView1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.batchGridView1.AutoGenerateColumns = false;
            this.batchGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.batchGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.batchGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.batchGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.batchGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.batchGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.batchIDDataGridViewTextBoxColumn,
            this.openedTimeDataGridViewTextBoxColumn,
            this.openedUserDataGridViewTextBoxColumn,
            this.submittedDateDataGridViewTextBoxColumn,
            this.submittedUserDataGridViewTextBoxColumn,
            this.oFACVerifiedDataGridViewCheckBoxColumn});
            this.batchGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.batchGridView1.DataSource = this.batchBindingSource;
            this.batchGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.batchGridView1.Location = new System.Drawing.Point(12, 180);
            this.batchGridView1.MultiSelect = false;
            this.batchGridView1.Name = "batchGridView1";
            this.batchGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.batchGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.batchGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.batchGridView1.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(1);
            this.batchGridView1.RowTemplate.Height = 15;
            this.batchGridView1.RowTemplate.ReadOnly = true;
            this.batchGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.batchGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.batchGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.batchGridView1.Size = new System.Drawing.Size(679, 123);
            this.batchGridView1.TabIndex = 5;
            // 
            // batchIDDataGridViewTextBoxColumn
            // 
            this.batchIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.batchIDDataGridViewTextBoxColumn.DataPropertyName = "BatchID";
            this.batchIDDataGridViewTextBoxColumn.HeaderText = "Batch ID";
            this.batchIDDataGridViewTextBoxColumn.Name = "batchIDDataGridViewTextBoxColumn";
            this.batchIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.batchIDDataGridViewTextBoxColumn.Width = 110;
            // 
            // openedTimeDataGridViewTextBoxColumn
            // 
            this.openedTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.openedTimeDataGridViewTextBoxColumn.DataPropertyName = "Opened_Time";
            this.openedTimeDataGridViewTextBoxColumn.HeaderText = "Opened Date/Time";
            this.openedTimeDataGridViewTextBoxColumn.Name = "openedTimeDataGridViewTextBoxColumn";
            this.openedTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // openedUserDataGridViewTextBoxColumn
            // 
            this.openedUserDataGridViewTextBoxColumn.DataPropertyName = "Opened_User";
            this.openedUserDataGridViewTextBoxColumn.HeaderText = "Opened By";
            this.openedUserDataGridViewTextBoxColumn.Name = "openedUserDataGridViewTextBoxColumn";
            this.openedUserDataGridViewTextBoxColumn.ReadOnly = true;
            this.openedUserDataGridViewTextBoxColumn.Width = 87;
            // 
            // submittedDateDataGridViewTextBoxColumn
            // 
            this.submittedDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.submittedDateDataGridViewTextBoxColumn.DataPropertyName = "Submitted_Date";
            this.submittedDateDataGridViewTextBoxColumn.HeaderText = "Submitted Date/Time";
            this.submittedDateDataGridViewTextBoxColumn.Name = "submittedDateDataGridViewTextBoxColumn";
            this.submittedDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // submittedUserDataGridViewTextBoxColumn
            // 
            this.submittedUserDataGridViewTextBoxColumn.DataPropertyName = "Submitted_User";
            this.submittedUserDataGridViewTextBoxColumn.HeaderText = "Submitted By";
            this.submittedUserDataGridViewTextBoxColumn.Name = "submittedUserDataGridViewTextBoxColumn";
            this.submittedUserDataGridViewTextBoxColumn.ReadOnly = true;
            this.submittedUserDataGridViewTextBoxColumn.Width = 97;
            // 
            // oFACVerifiedDataGridViewCheckBoxColumn
            // 
            this.oFACVerifiedDataGridViewCheckBoxColumn.DataPropertyName = "OFAC_Verified";
            this.oFACVerifiedDataGridViewCheckBoxColumn.HeaderText = "OFAC_Verified";
            this.oFACVerifiedDataGridViewCheckBoxColumn.Name = "oFACVerifiedDataGridViewCheckBoxColumn";
            this.oFACVerifiedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.oFACVerifiedDataGridViewCheckBoxColumn.Width = 95;
            // 
            // batchBindingSource
            // 
            this.batchBindingSource.DataMember = "Batch";
            this.batchBindingSource.DataSource = this.fWFCdbDataSetBatchFull;
            // 
            // fWFCdbDataSetBatchFull
            // 
            this.fWFCdbDataSetBatchFull.DataSetName = "FWFCdbDataSetBatchFull";
            this.fWFCdbDataSetBatchFull.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fWFCdbDataSet
            // 
            this.fWFCdbDataSet.DataSetName = "FWFCdbDataSet";
            this.fWFCdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fWFCdbDataSetBindingSource
            // 
            this.fWFCdbDataSetBindingSource.DataSource = this.fWFCdbDataSet;
            this.fWFCdbDataSetBindingSource.Position = 0;
            // 
            // batchTableAdapter
            // 
            this.batchTableAdapter.ClearBeforeFill = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 315);
            this.Controls.Add(this.batchGridView1);
            this.Controls.Add(this.openTemplateButton);
            this.Controls.Add(this.openReportsButton);
            this.Controls.Add(this.openNewInternationalWireButton);
            this.Controls.Add(this.openNewDomesticWireButton);
            this.Controls.Add(this.mainMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainMenu";
            this.Text = "(FWFC) FedWire File Creator";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batchGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fWFCdbDataSetBatchFull)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fWFCdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fWFCdbDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem domesticWireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalWireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFromTemplateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem domesticWireToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem internationalWireToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem oFACCheckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importBatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportBatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem securityQuestionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutFWFCToolStripMenuItem;
        private System.Windows.Forms.Button openNewDomesticWireButton;
        private System.Windows.Forms.Button openNewInternationalWireButton;
        private System.Windows.Forms.Button openReportsButton;
        private System.Windows.Forms.Button openTemplateButton;
        private System.Windows.Forms.DataGridView batchGridView1;
        private System.Windows.Forms.BindingSource fWFCdbDataSetBindingSource;
        private FWFCdbDataSet fWFCdbDataSet;
        private FWFCdbDataSetBatchFull fWFCdbDataSetBatchFull;
        private System.Windows.Forms.BindingSource batchBindingSource;
        private FWFCdbDataSetBatchFullTableAdapters.BatchTableAdapter batchTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openedTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openedUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn submittedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn submittedUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn oFACVerifiedDataGridViewCheckBoxColumn;
    }
}