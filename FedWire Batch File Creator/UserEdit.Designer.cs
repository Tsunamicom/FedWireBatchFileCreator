namespace FedWire_Batch_File_Creator
{
    partial class UserEdit
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
            this.userListComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxPermissions = new System.Windows.Forms.GroupBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.textBoxPassword1 = new System.Windows.Forms.TextBox();
            this.textBoxPassword2 = new System.Windows.Forms.TextBox();
            this.buttonEditUser = new System.Windows.Forms.Button();
            this.buttonCreateNew = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.labelPasswordChangeInstruct = new System.Windows.Forms.Label();
            this.pictureBoxUserImage = new System.Windows.Forms.PictureBox();
            this.checkBoxAdmin = new System.Windows.Forms.CheckBox();
            this.checkBoxCreateNewBatch = new System.Windows.Forms.CheckBox();
            this.checkBoxVerifyBatch = new System.Windows.Forms.CheckBox();
            this.checkBoxModifyBatch = new System.Windows.Forms.CheckBox();
            this.checkBoxExportBatch = new System.Windows.Forms.CheckBox();
            this.checkBoxDeleteBatch = new System.Windows.Forms.CheckBox();
            this.checkBoxCreateNewWire = new System.Windows.Forms.CheckBox();
            this.checkBoxVerifyWire = new System.Windows.Forms.CheckBox();
            this.checkBoxModifyWire = new System.Windows.Forms.CheckBox();
            this.checkBoxDeleteWire = new System.Windows.Forms.CheckBox();
            this.checkBoxDeleteTemplate = new System.Windows.Forms.CheckBox();
            this.checkBoxModifyTemplate = new System.Windows.Forms.CheckBox();
            this.checkBoxVerifyTemplate = new System.Windows.Forms.CheckBox();
            this.checkBoxNewTemplate = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBoxPermissions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserImage)).BeginInit();
            this.SuspendLayout();
            // 
            // userListComboBox
            // 
            this.userListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userListComboBox.FormattingEnabled = true;
            this.userListComboBox.Location = new System.Drawing.Point(21, 19);
            this.userListComboBox.Name = "userListComboBox";
            this.userListComboBox.Size = new System.Drawing.Size(237, 21);
            this.userListComboBox.TabIndex = 0;
            this.userListComboBox.SelectedValueChanged += new System.EventHandler(this.userListComboBox_SelectedValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBoxUserImage);
            this.groupBox1.Controls.Add(this.labelPasswordChangeInstruct);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.buttonCreateNew);
            this.groupBox1.Controls.Add(this.buttonEditUser);
            this.groupBox1.Controls.Add(this.textBoxPassword2);
            this.groupBox1.Controls.Add(this.textBoxUserName);
            this.groupBox1.Controls.Add(this.labelUserName);
            this.groupBox1.Controls.Add(this.textBoxPassword1);
            this.groupBox1.Controls.Add(this.textBoxLastName);
            this.groupBox1.Controls.Add(this.labelLastName);
            this.groupBox1.Controls.Add(this.textBoxFirstName);
            this.groupBox1.Controls.Add(this.labelFirstName);
            this.groupBox1.Controls.Add(this.userListComboBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 285);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Details";
            // 
            // groupBoxPermissions
            // 
            this.groupBoxPermissions.Controls.Add(this.checkBoxDeleteTemplate);
            this.groupBoxPermissions.Controls.Add(this.checkBoxModifyTemplate);
            this.groupBoxPermissions.Controls.Add(this.checkBoxVerifyTemplate);
            this.groupBoxPermissions.Controls.Add(this.checkBoxNewTemplate);
            this.groupBoxPermissions.Controls.Add(this.checkBoxDeleteWire);
            this.groupBoxPermissions.Controls.Add(this.checkBoxModifyWire);
            this.groupBoxPermissions.Controls.Add(this.checkBoxVerifyWire);
            this.groupBoxPermissions.Controls.Add(this.checkBoxCreateNewWire);
            this.groupBoxPermissions.Controls.Add(this.checkBoxDeleteBatch);
            this.groupBoxPermissions.Controls.Add(this.checkBoxExportBatch);
            this.groupBoxPermissions.Controls.Add(this.checkBoxModifyBatch);
            this.groupBoxPermissions.Controls.Add(this.checkBoxVerifyBatch);
            this.groupBoxPermissions.Controls.Add(this.checkBoxCreateNewBatch);
            this.groupBoxPermissions.Controls.Add(this.checkBoxAdmin);
            this.groupBoxPermissions.Enabled = false;
            this.groupBoxPermissions.Location = new System.Drawing.Point(520, 12);
            this.groupBoxPermissions.Name = "groupBoxPermissions";
            this.groupBoxPermissions.Size = new System.Drawing.Size(293, 285);
            this.groupBoxPermissions.TabIndex = 8;
            this.groupBoxPermissions.TabStop = false;
            this.groupBoxPermissions.Text = "Permissions";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Enabled = false;
            this.labelFirstName.Location = new System.Drawing.Point(275, 142);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(60, 13);
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Text = "First Name:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Enabled = false;
            this.textBoxFirstName.Location = new System.Drawing.Point(341, 139);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(124, 20);
            this.textBoxFirstName.TabIndex = 2;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Enabled = false;
            this.textBoxLastName.Location = new System.Drawing.Point(341, 165);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(124, 20);
            this.textBoxLastName.TabIndex = 4;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Enabled = false;
            this.labelLastName.Location = new System.Drawing.Point(275, 168);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(61, 13);
            this.labelLastName.TabIndex = 3;
            this.labelLastName.Text = "Last Name:";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Enabled = false;
            this.textBoxUserName.Location = new System.Drawing.Point(341, 81);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(124, 20);
            this.textBoxUserName.TabIndex = 8;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Enabled = false;
            this.labelUserName.Location = new System.Drawing.Point(272, 84);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(63, 13);
            this.labelUserName.TabIndex = 7;
            this.labelUserName.Text = "User Name:";
            // 
            // textBoxPassword1
            // 
            this.textBoxPassword1.Enabled = false;
            this.textBoxPassword1.Location = new System.Drawing.Point(341, 225);
            this.textBoxPassword1.Name = "textBoxPassword1";
            this.textBoxPassword1.Size = new System.Drawing.Size(124, 20);
            this.textBoxPassword1.TabIndex = 6;
            // 
            // textBoxPassword2
            // 
            this.textBoxPassword2.Enabled = false;
            this.textBoxPassword2.Location = new System.Drawing.Point(341, 251);
            this.textBoxPassword2.Name = "textBoxPassword2";
            this.textBoxPassword2.Size = new System.Drawing.Size(124, 20);
            this.textBoxPassword2.TabIndex = 12;
            // 
            // buttonEditUser
            // 
            this.buttonEditUser.Enabled = false;
            this.buttonEditUser.Location = new System.Drawing.Point(284, 19);
            this.buttonEditUser.Name = "buttonEditUser";
            this.buttonEditUser.Size = new System.Drawing.Size(75, 23);
            this.buttonEditUser.TabIndex = 13;
            this.buttonEditUser.Text = "Edit User";
            this.buttonEditUser.UseVisualStyleBackColor = true;
            // 
            // buttonCreateNew
            // 
            this.buttonCreateNew.Location = new System.Drawing.Point(390, 19);
            this.buttonCreateNew.Name = "buttonCreateNew";
            this.buttonCreateNew.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateNew.TabIndex = 14;
            this.buttonCreateNew.Text = "Create New";
            this.buttonCreateNew.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(235, 228);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 42);
            this.button3.TabIndex = 15;
            this.button3.Text = "Change Password";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // labelPasswordChangeInstruct
            // 
            this.labelPasswordChangeInstruct.AutoSize = true;
            this.labelPasswordChangeInstruct.Location = new System.Drawing.Point(390, 104);
            this.labelPasswordChangeInstruct.Name = "labelPasswordChangeInstruct";
            this.labelPasswordChangeInstruct.Size = new System.Drawing.Size(0, 13);
            this.labelPasswordChangeInstruct.TabIndex = 16;
            // 
            // pictureBoxUserImage
            // 
            this.pictureBoxUserImage.Image = global::FedWire_Batch_File_Creator.Properties.Resources.user_login_icon_14;
            this.pictureBoxUserImage.Location = new System.Drawing.Point(21, 60);
            this.pictureBoxUserImage.Name = "pictureBoxUserImage";
            this.pictureBoxUserImage.Size = new System.Drawing.Size(208, 210);
            this.pictureBoxUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUserImage.TabIndex = 17;
            this.pictureBoxUserImage.TabStop = false;
            // 
            // checkBoxAdmin
            // 
            this.checkBoxAdmin.AutoSize = true;
            this.checkBoxAdmin.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdmin.Location = new System.Drawing.Point(120, 19);
            this.checkBoxAdmin.Name = "checkBoxAdmin";
            this.checkBoxAdmin.Size = new System.Drawing.Size(66, 17);
            this.checkBoxAdmin.TabIndex = 18;
            this.checkBoxAdmin.Text = "ADMIN";
            this.checkBoxAdmin.UseVisualStyleBackColor = true;
            // 
            // checkBoxCreateNewBatch
            // 
            this.checkBoxCreateNewBatch.AutoSize = true;
            this.checkBoxCreateNewBatch.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxCreateNewBatch.Location = new System.Drawing.Point(28, 67);
            this.checkBoxCreateNewBatch.Name = "checkBoxCreateNewBatch";
            this.checkBoxCreateNewBatch.Size = new System.Drawing.Size(113, 17);
            this.checkBoxCreateNewBatch.TabIndex = 19;
            this.checkBoxCreateNewBatch.Text = "Create New Batch";
            this.checkBoxCreateNewBatch.UseVisualStyleBackColor = true;
            // 
            // checkBoxVerifyBatch
            // 
            this.checkBoxVerifyBatch.AutoSize = true;
            this.checkBoxVerifyBatch.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxVerifyBatch.Location = new System.Drawing.Point(58, 90);
            this.checkBoxVerifyBatch.Name = "checkBoxVerifyBatch";
            this.checkBoxVerifyBatch.Size = new System.Drawing.Size(83, 17);
            this.checkBoxVerifyBatch.TabIndex = 20;
            this.checkBoxVerifyBatch.Text = "Verify Batch";
            this.checkBoxVerifyBatch.UseVisualStyleBackColor = true;
            // 
            // checkBoxModifyBatch
            // 
            this.checkBoxModifyBatch.AutoSize = true;
            this.checkBoxModifyBatch.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxModifyBatch.Location = new System.Drawing.Point(199, 67);
            this.checkBoxModifyBatch.Name = "checkBoxModifyBatch";
            this.checkBoxModifyBatch.Size = new System.Drawing.Size(88, 17);
            this.checkBoxModifyBatch.TabIndex = 21;
            this.checkBoxModifyBatch.Text = "Modify Batch";
            this.checkBoxModifyBatch.UseVisualStyleBackColor = true;
            // 
            // checkBoxExportBatch
            // 
            this.checkBoxExportBatch.AutoSize = true;
            this.checkBoxExportBatch.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxExportBatch.Location = new System.Drawing.Point(54, 113);
            this.checkBoxExportBatch.Name = "checkBoxExportBatch";
            this.checkBoxExportBatch.Size = new System.Drawing.Size(87, 17);
            this.checkBoxExportBatch.TabIndex = 22;
            this.checkBoxExportBatch.Text = "Export Batch";
            this.checkBoxExportBatch.UseVisualStyleBackColor = true;
            // 
            // checkBoxDeleteBatch
            // 
            this.checkBoxDeleteBatch.AutoSize = true;
            this.checkBoxDeleteBatch.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxDeleteBatch.Location = new System.Drawing.Point(199, 90);
            this.checkBoxDeleteBatch.Name = "checkBoxDeleteBatch";
            this.checkBoxDeleteBatch.Size = new System.Drawing.Size(88, 17);
            this.checkBoxDeleteBatch.TabIndex = 23;
            this.checkBoxDeleteBatch.Text = "Delete Batch";
            this.checkBoxDeleteBatch.UseVisualStyleBackColor = true;
            // 
            // checkBoxCreateNewWire
            // 
            this.checkBoxCreateNewWire.AutoSize = true;
            this.checkBoxCreateNewWire.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxCreateNewWire.Location = new System.Drawing.Point(34, 152);
            this.checkBoxCreateNewWire.Name = "checkBoxCreateNewWire";
            this.checkBoxCreateNewWire.Size = new System.Drawing.Size(107, 17);
            this.checkBoxCreateNewWire.TabIndex = 24;
            this.checkBoxCreateNewWire.Text = "Create New Wire";
            this.checkBoxCreateNewWire.UseVisualStyleBackColor = true;
            // 
            // checkBoxVerifyWire
            // 
            this.checkBoxVerifyWire.AutoSize = true;
            this.checkBoxVerifyWire.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxVerifyWire.Location = new System.Drawing.Point(64, 175);
            this.checkBoxVerifyWire.Name = "checkBoxVerifyWire";
            this.checkBoxVerifyWire.Size = new System.Drawing.Size(77, 17);
            this.checkBoxVerifyWire.TabIndex = 25;
            this.checkBoxVerifyWire.Text = "Verify Wire";
            this.checkBoxVerifyWire.UseVisualStyleBackColor = true;
            // 
            // checkBoxModifyWire
            // 
            this.checkBoxModifyWire.AutoSize = true;
            this.checkBoxModifyWire.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxModifyWire.Location = new System.Drawing.Point(205, 152);
            this.checkBoxModifyWire.Name = "checkBoxModifyWire";
            this.checkBoxModifyWire.Size = new System.Drawing.Size(82, 17);
            this.checkBoxModifyWire.TabIndex = 26;
            this.checkBoxModifyWire.Text = "Modify Wire";
            this.checkBoxModifyWire.UseVisualStyleBackColor = true;
            // 
            // checkBoxDeleteWire
            // 
            this.checkBoxDeleteWire.AutoSize = true;
            this.checkBoxDeleteWire.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxDeleteWire.Location = new System.Drawing.Point(205, 175);
            this.checkBoxDeleteWire.Name = "checkBoxDeleteWire";
            this.checkBoxDeleteWire.Size = new System.Drawing.Size(82, 17);
            this.checkBoxDeleteWire.TabIndex = 27;
            this.checkBoxDeleteWire.Text = "Delete Wire";
            this.checkBoxDeleteWire.UseVisualStyleBackColor = true;
            // 
            // checkBoxDeleteTemplate
            // 
            this.checkBoxDeleteTemplate.AutoSize = true;
            this.checkBoxDeleteTemplate.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxDeleteTemplate.Location = new System.Drawing.Point(183, 242);
            this.checkBoxDeleteTemplate.Name = "checkBoxDeleteTemplate";
            this.checkBoxDeleteTemplate.Size = new System.Drawing.Size(104, 17);
            this.checkBoxDeleteTemplate.TabIndex = 31;
            this.checkBoxDeleteTemplate.Text = "Delete Template";
            this.checkBoxDeleteTemplate.UseVisualStyleBackColor = true;
            // 
            // checkBoxModifyTemplate
            // 
            this.checkBoxModifyTemplate.AutoSize = true;
            this.checkBoxModifyTemplate.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxModifyTemplate.Location = new System.Drawing.Point(183, 219);
            this.checkBoxModifyTemplate.Name = "checkBoxModifyTemplate";
            this.checkBoxModifyTemplate.Size = new System.Drawing.Size(104, 17);
            this.checkBoxModifyTemplate.TabIndex = 30;
            this.checkBoxModifyTemplate.Text = "Modify Template";
            this.checkBoxModifyTemplate.UseVisualStyleBackColor = true;
            // 
            // checkBoxVerifyTemplate
            // 
            this.checkBoxVerifyTemplate.AutoSize = true;
            this.checkBoxVerifyTemplate.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxVerifyTemplate.Location = new System.Drawing.Point(42, 242);
            this.checkBoxVerifyTemplate.Name = "checkBoxVerifyTemplate";
            this.checkBoxVerifyTemplate.Size = new System.Drawing.Size(99, 17);
            this.checkBoxVerifyTemplate.TabIndex = 29;
            this.checkBoxVerifyTemplate.Text = "Verify Template";
            this.checkBoxVerifyTemplate.UseVisualStyleBackColor = true;
            // 
            // checkBoxNewTemplate
            // 
            this.checkBoxNewTemplate.AutoSize = true;
            this.checkBoxNewTemplate.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxNewTemplate.Location = new System.Drawing.Point(12, 219);
            this.checkBoxNewTemplate.Name = "checkBoxNewTemplate";
            this.checkBoxNewTemplate.Size = new System.Drawing.Size(129, 17);
            this.checkBoxNewTemplate.TabIndex = 28;
            this.checkBoxNewTemplate.Text = "Create New Template";
            this.checkBoxNewTemplate.UseVisualStyleBackColor = true;
            // 
            // UserEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 305);
            this.Controls.Add(this.groupBoxPermissions);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "UserEdit";
            this.Text = "User Control - Edit or Create";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxPermissions.ResumeLayout(false);
            this.groupBoxPermissions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox userListComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxPermissions;
        private System.Windows.Forms.TextBox textBoxPassword2;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.TextBox textBoxPassword1;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonCreateNew;
        private System.Windows.Forms.Button buttonEditUser;
        private System.Windows.Forms.Label labelPasswordChangeInstruct;
        private System.Windows.Forms.PictureBox pictureBoxUserImage;
        private System.Windows.Forms.CheckBox checkBoxDeleteTemplate;
        private System.Windows.Forms.CheckBox checkBoxModifyTemplate;
        private System.Windows.Forms.CheckBox checkBoxVerifyTemplate;
        private System.Windows.Forms.CheckBox checkBoxNewTemplate;
        private System.Windows.Forms.CheckBox checkBoxDeleteWire;
        private System.Windows.Forms.CheckBox checkBoxModifyWire;
        private System.Windows.Forms.CheckBox checkBoxVerifyWire;
        private System.Windows.Forms.CheckBox checkBoxCreateNewWire;
        private System.Windows.Forms.CheckBox checkBoxDeleteBatch;
        private System.Windows.Forms.CheckBox checkBoxExportBatch;
        private System.Windows.Forms.CheckBox checkBoxModifyBatch;
        private System.Windows.Forms.CheckBox checkBoxVerifyBatch;
        private System.Windows.Forms.CheckBox checkBoxCreateNewBatch;
        private System.Windows.Forms.CheckBox checkBoxAdmin;
    }
}