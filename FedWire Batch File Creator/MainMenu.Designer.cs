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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.userOptionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(351, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            this.exitToolStripMenuItem.Text = "&Exit";
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
            this.openNewDomesticWireButton.Location = new System.Drawing.Point(12, 39);
            this.openNewDomesticWireButton.Name = "openNewDomesticWireButton";
            this.openNewDomesticWireButton.Size = new System.Drawing.Size(150, 100);
            this.openNewDomesticWireButton.TabIndex = 1;
            this.openNewDomesticWireButton.Text = "DOMESTIC WIRE";
            this.openNewDomesticWireButton.UseVisualStyleBackColor = true;
            this.openNewDomesticWireButton.Click += new System.EventHandler(this.openNewDomesticWireButton_Click);
            // 
            // openNewInternationalWireButton
            // 
            this.openNewInternationalWireButton.FlatAppearance.BorderSize = 5;
            this.openNewInternationalWireButton.Location = new System.Drawing.Point(185, 39);
            this.openNewInternationalWireButton.Name = "openNewInternationalWireButton";
            this.openNewInternationalWireButton.Size = new System.Drawing.Size(150, 100);
            this.openNewInternationalWireButton.TabIndex = 2;
            this.openNewInternationalWireButton.Text = "INTERNATIONAL WIRE (TBD)";
            this.openNewInternationalWireButton.UseVisualStyleBackColor = true;
            // 
            // openReportsButton
            // 
            this.openReportsButton.Location = new System.Drawing.Point(12, 162);
            this.openReportsButton.Name = "openReportsButton";
            this.openReportsButton.Size = new System.Drawing.Size(150, 100);
            this.openReportsButton.TabIndex = 3;
            this.openReportsButton.Text = "REPORTS (TBD)";
            this.openReportsButton.UseVisualStyleBackColor = true;
            // 
            // openTemplateButton
            // 
            this.openTemplateButton.Location = new System.Drawing.Point(185, 162);
            this.openTemplateButton.Name = "openTemplateButton";
            this.openTemplateButton.Size = new System.Drawing.Size(150, 100);
            this.openTemplateButton.TabIndex = 4;
            this.openTemplateButton.Text = "HISTORY (TBD)";
            this.openTemplateButton.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 274);
            this.Controls.Add(this.openTemplateButton);
            this.Controls.Add(this.openReportsButton);
            this.Controls.Add(this.openNewInternationalWireButton);
            this.Controls.Add(this.openNewDomesticWireButton);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "(FWFG) FedWire File Generator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
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
    }
}