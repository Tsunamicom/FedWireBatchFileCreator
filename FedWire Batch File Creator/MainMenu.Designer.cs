﻿namespace FedWire_Batch_File_Creator
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fedWireBasicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fedWireComplexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.administrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createEditUserToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutFWFCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openNewDomesticWireButton = new System.Windows.Forms.Button();
            this.openNewComplexFedWireButton = new System.Windows.Forms.Button();
            this.openReportsButton = new System.Windows.Forms.Button();
            this.openTemplateButton = new System.Windows.Forms.Button();
            this.labelFNLNShow = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fWFCdbDataSetViews = new FedWire_Batch_File_Creator.FWFCdbDataSetViews();
            this.batchSummaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.batchSummaryTableAdapter = new FedWire_Batch_File_Creator.FWFCdbDataSetViewsTableAdapters.BatchSummaryTableAdapter();
            this.batchIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openedUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openedTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfWiresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalWireAmtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oFACVerifiedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fWFCdbDataSetViews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batchSummaryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.userOptionsToolStripMenuItem,
            this.administrationToolStripMenuItem,
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
            this.fedWireBasicToolStripMenuItem,
            this.fedWireComplexToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.newToolStripMenuItem.Text = "&New Wire";
            // 
            // fedWireBasicToolStripMenuItem
            // 
            this.fedWireBasicToolStripMenuItem.Name = "fedWireBasicToolStripMenuItem";
            this.fedWireBasicToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.fedWireBasicToolStripMenuItem.Text = "FedWire (Basic)";
            this.fedWireBasicToolStripMenuItem.Click += new System.EventHandler(this.domesticWireToolStripMenuItem_Click);
            // 
            // fedWireComplexToolStripMenuItem
            // 
            this.fedWireComplexToolStripMenuItem.Enabled = false;
            this.fedWireComplexToolStripMenuItem.Name = "fedWireComplexToolStripMenuItem";
            this.fedWireComplexToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.fedWireComplexToolStripMenuItem.Text = "FedWire (Complex)";
            // 
            // newFromTemplateToolStripMenuItem
            // 
            this.newFromTemplateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.internationalWireToolStripMenuItem1,
            this.domesticWireToolStripMenuItem1});
            this.newFromTemplateToolStripMenuItem.Enabled = false;
            this.newFromTemplateToolStripMenuItem.Name = "newFromTemplateToolStripMenuItem";
            this.newFromTemplateToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.newFromTemplateToolStripMenuItem.Text = "&Templates";
            // 
            // internationalWireToolStripMenuItem1
            // 
            this.internationalWireToolStripMenuItem1.Name = "internationalWireToolStripMenuItem1";
            this.internationalWireToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.internationalWireToolStripMenuItem1.Text = "&New";
            // 
            // domesticWireToolStripMenuItem1
            // 
            this.domesticWireToolStripMenuItem1.Name = "domesticWireToolStripMenuItem1";
            this.domesticWireToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.domesticWireToolStripMenuItem1.Text = "&Open";
            // 
            // importBatchToolStripMenuItem
            // 
            this.importBatchToolStripMenuItem.Enabled = false;
            this.importBatchToolStripMenuItem.Name = "importBatchToolStripMenuItem";
            this.importBatchToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.importBatchToolStripMenuItem.Text = "&Import Batch";
            // 
            // exportBatchToolStripMenuItem
            // 
            this.exportBatchToolStripMenuItem.Enabled = false;
            this.exportBatchToolStripMenuItem.Name = "exportBatchToolStripMenuItem";
            this.exportBatchToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.exportBatchToolStripMenuItem.Text = "&Export Batch";
            // 
            // oFACCheckToolStripMenuItem
            // 
            this.oFACCheckToolStripMenuItem.Enabled = false;
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
            this.viewToolStripMenuItem.Enabled = false;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.reportsToolStripMenuItem.Text = "&Reports";
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
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
            this.changePasswordToolStripMenuItem.Enabled = false;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.changePasswordToolStripMenuItem.Text = "&Change Password";
            // 
            // securityQuestionsToolStripMenuItem
            // 
            this.securityQuestionsToolStripMenuItem.Enabled = false;
            this.securityQuestionsToolStripMenuItem.Name = "securityQuestionsToolStripMenuItem";
            this.securityQuestionsToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.securityQuestionsToolStripMenuItem.Text = "Update &Security Questions";
            // 
            // logoutToolStripMenuItem1
            // 
            this.logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
            this.logoutToolStripMenuItem1.Size = new System.Drawing.Size(213, 22);
            this.logoutToolStripMenuItem1.Text = "&Logout";
            this.logoutToolStripMenuItem1.Click += new System.EventHandler(this.logoutToolStripMenuItem1_Click);
            // 
            // administrationToolStripMenuItem
            // 
            this.administrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createEditUserToolStripMenuItem1});
            this.administrationToolStripMenuItem.Name = "administrationToolStripMenuItem";
            this.administrationToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.administrationToolStripMenuItem.Text = "Administration";
            this.administrationToolStripMenuItem.Visible = false;
            // 
            // createEditUserToolStripMenuItem1
            // 
            this.createEditUserToolStripMenuItem1.Name = "createEditUserToolStripMenuItem1";
            this.createEditUserToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.createEditUserToolStripMenuItem1.Text = "Create/Edit User";
            this.createEditUserToolStripMenuItem1.Click += new System.EventHandler(this.createEditUserToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.aboutFWFCToolStripMenuItem});
            this.helpToolStripMenuItem.Enabled = false;
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
            this.openNewDomesticWireButton.Location = new System.Drawing.Point(12, 47);
            this.openNewDomesticWireButton.Name = "openNewDomesticWireButton";
            this.openNewDomesticWireButton.Size = new System.Drawing.Size(150, 100);
            this.openNewDomesticWireButton.TabIndex = 1;
            this.openNewDomesticWireButton.Text = "NEW FEDWIRE (BASIC)";
            this.openNewDomesticWireButton.UseVisualStyleBackColor = true;
            this.openNewDomesticWireButton.Click += new System.EventHandler(this.openNewDomesticWireButton_Click);
            // 
            // openNewComplexFedWireButton
            // 
            this.openNewComplexFedWireButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openNewComplexFedWireButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.openNewComplexFedWireButton.Enabled = false;
            this.openNewComplexFedWireButton.FlatAppearance.BorderSize = 5;
            this.openNewComplexFedWireButton.Location = new System.Drawing.Point(187, 47);
            this.openNewComplexFedWireButton.Name = "openNewComplexFedWireButton";
            this.openNewComplexFedWireButton.Size = new System.Drawing.Size(150, 100);
            this.openNewComplexFedWireButton.TabIndex = 2;
            this.openNewComplexFedWireButton.Text = "NEW FEDWIRE (COMPLEX)";
            this.openNewComplexFedWireButton.UseVisualStyleBackColor = true;
            // 
            // openReportsButton
            // 
            this.openReportsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openReportsButton.Enabled = false;
            this.openReportsButton.Location = new System.Drawing.Point(362, 47);
            this.openReportsButton.Name = "openReportsButton";
            this.openReportsButton.Size = new System.Drawing.Size(150, 100);
            this.openReportsButton.TabIndex = 3;
            this.openReportsButton.Text = "REPORTS";
            this.openReportsButton.UseVisualStyleBackColor = true;
            // 
            // openTemplateButton
            // 
            this.openTemplateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openTemplateButton.Enabled = false;
            this.openTemplateButton.Location = new System.Drawing.Point(541, 47);
            this.openTemplateButton.Name = "openTemplateButton";
            this.openTemplateButton.Size = new System.Drawing.Size(150, 100);
            this.openTemplateButton.TabIndex = 4;
            this.openTemplateButton.Text = "HISTORY";
            this.openTemplateButton.UseVisualStyleBackColor = true;
            // 
            // labelFNLNShow
            // 
            this.labelFNLNShow.AutoSize = true;
            this.labelFNLNShow.Location = new System.Drawing.Point(12, 31);
            this.labelFNLNShow.Name = "labelFNLNShow";
            this.labelFNLNShow.Size = new System.Drawing.Size(86, 13);
            this.labelFNLNShow.TabIndex = 5;
            this.labelFNLNShow.Text = "Current User: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.batchIDDataGridViewTextBoxColumn,
            this.openedUserDataGridViewTextBoxColumn,
            this.openedTimeDataGridViewTextBoxColumn,
            this.numberOfWiresDataGridViewTextBoxColumn,
            this.totalWireAmtDataGridViewTextBoxColumn,
            this.oFACVerifiedDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.batchSummaryBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 166);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(678, 150);
            this.dataGridView1.TabIndex = 6;
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
            this.batchIDDataGridViewTextBoxColumn.DataPropertyName = "BatchID";
            this.batchIDDataGridViewTextBoxColumn.HeaderText = "Batch ID";
            this.batchIDDataGridViewTextBoxColumn.Name = "batchIDDataGridViewTextBoxColumn";
            this.batchIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.batchIDDataGridViewTextBoxColumn.Width = 82;
            // 
            // openedUserDataGridViewTextBoxColumn
            // 
            this.openedUserDataGridViewTextBoxColumn.DataPropertyName = "Opened_User";
            this.openedUserDataGridViewTextBoxColumn.HeaderText = "Opened_User";
            this.openedUserDataGridViewTextBoxColumn.Name = "openedUserDataGridViewTextBoxColumn";
            this.openedUserDataGridViewTextBoxColumn.ReadOnly = true;
            this.openedUserDataGridViewTextBoxColumn.Width = 109;
            // 
            // openedTimeDataGridViewTextBoxColumn
            // 
            this.openedTimeDataGridViewTextBoxColumn.DataPropertyName = "Opened_Time";
            this.openedTimeDataGridViewTextBoxColumn.HeaderText = "Opened_Time";
            this.openedTimeDataGridViewTextBoxColumn.Name = "openedTimeDataGridViewTextBoxColumn";
            this.openedTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.openedTimeDataGridViewTextBoxColumn.Width = 110;
            // 
            // numberOfWiresDataGridViewTextBoxColumn
            // 
            this.numberOfWiresDataGridViewTextBoxColumn.DataPropertyName = "Number of Wires";
            this.numberOfWiresDataGridViewTextBoxColumn.HeaderText = "Number of Wires";
            this.numberOfWiresDataGridViewTextBoxColumn.Name = "numberOfWiresDataGridViewTextBoxColumn";
            this.numberOfWiresDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberOfWiresDataGridViewTextBoxColumn.Width = 87;
            // 
            // totalWireAmtDataGridViewTextBoxColumn
            // 
            this.totalWireAmtDataGridViewTextBoxColumn.DataPropertyName = "Total Wire Amt";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.totalWireAmtDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.totalWireAmtDataGridViewTextBoxColumn.HeaderText = "Total Wire Amt";
            this.totalWireAmtDataGridViewTextBoxColumn.Name = "totalWireAmtDataGridViewTextBoxColumn";
            this.totalWireAmtDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalWireAmtDataGridViewTextBoxColumn.Width = 87;
            // 
            // oFACVerifiedDataGridViewCheckBoxColumn
            // 
            this.oFACVerifiedDataGridViewCheckBoxColumn.DataPropertyName = "OFAC_Verified";
            this.oFACVerifiedDataGridViewCheckBoxColumn.HeaderText = "OFAC_Verified";
            this.oFACVerifiedDataGridViewCheckBoxColumn.Name = "oFACVerifiedDataGridViewCheckBoxColumn";
            this.oFACVerifiedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.oFACVerifiedDataGridViewCheckBoxColumn.Width = 95;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 315);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelFNLNShow);
            this.Controls.Add(this.openTemplateButton);
            this.Controls.Add(this.openReportsButton);
            this.Controls.Add(this.openNewComplexFedWireButton);
            this.Controls.Add(this.openNewDomesticWireButton);
            this.Controls.Add(this.mainMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainMenu";
            this.Text = "(FWFC) FedWire File Creator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fWFCdbDataSetViews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batchSummaryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fedWireBasicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fedWireComplexToolStripMenuItem;
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
        private System.Windows.Forms.Button openNewComplexFedWireButton;
        private System.Windows.Forms.Button openReportsButton;
        private System.Windows.Forms.Button openTemplateButton;
        private System.Windows.Forms.Label labelFNLNShow;
        private System.Windows.Forms.ToolStripMenuItem administrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createEditUserToolStripMenuItem1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FWFCdbDataSetViews fWFCdbDataSetViews;
        private System.Windows.Forms.BindingSource batchSummaryBindingSource;
        private FWFCdbDataSetViewsTableAdapters.BatchSummaryTableAdapter batchSummaryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openedUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openedTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfWiresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalWireAmtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn oFACVerifiedDataGridViewCheckBoxColumn;
    }
}