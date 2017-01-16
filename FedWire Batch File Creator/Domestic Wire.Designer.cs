using System.Windows.Forms;

namespace FedWire_Batch_File_Creator
{
    partial class DomesticWireFrm
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
            this.FedWireDetailTitle = new System.Windows.Forms.Label();
            this.dbtCustAcctNum = new System.Windows.Forms.TextBox();
            this.dbtCustName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.obiText = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dbtCustAddrOne = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dbtCustAddrTwo = new System.Windows.Forms.TextBox();
            this.dbtCustAddrThree = new System.Windows.Forms.TextBox();
            this.dbtCustAddrFour = new System.Windows.Forms.TextBox();
            this.recBankAddrFour = new System.Windows.Forms.TextBox();
            this.recBankAddrThree = new System.Windows.Forms.TextBox();
            this.recBankAddrTwo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.recBankAddrOne = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.recBankName = new System.Windows.Forms.TextBox();
            this.recBankABA = new System.Windows.Forms.TextBox();
            this.bnfBankAddrFour = new System.Windows.Forms.TextBox();
            this.bnfBankAddrThree = new System.Windows.Forms.TextBox();
            this.bnfBankAddrTwo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bnfBankAddrOne = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.bnfBankName = new System.Windows.Forms.TextBox();
            this.bnfBankABA = new System.Windows.Forms.TextBox();
            this.bnfCustAddrFour = new System.Windows.Forms.TextBox();
            this.bnfCustAddrThree = new System.Windows.Forms.TextBox();
            this.bnfCustAddrTwo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.bnfCustAddrOne = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.bnfCustName = new System.Windows.Forms.TextBox();
            this.bnfCustAcctNum = new System.Windows.Forms.TextBox();
            this.fedWireDirectoryLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.recBankAcctType = new System.Windows.Forms.ComboBox();
            this.bnfBankAcctType = new System.Windows.Forms.ComboBox();
            this.wireFormSubmit = new System.Windows.Forms.Button();
            this.wireIDNum = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.wireFormVerify = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.wireAmt = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.activeUser = new System.Windows.Forms.Label();
            this.wireTypeSelect = new System.Windows.Forms.ComboBox();
            this.domesticWireHeaderMenu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label25 = new System.Windows.Forms.Label();
            this.initiatedTime = new System.Windows.Forms.Label();
            this.domesticWireHeaderMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // FedWireDetailTitle
            // 
            this.FedWireDetailTitle.AutoSize = true;
            this.FedWireDetailTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FedWireDetailTitle.Location = new System.Drawing.Point(299, 40);
            this.FedWireDetailTitle.Name = "FedWireDetailTitle";
            this.FedWireDetailTitle.Size = new System.Drawing.Size(170, 26);
            this.FedWireDetailTitle.TabIndex = 0;
            this.FedWireDetailTitle.Text = "FedWire Detail";
            this.FedWireDetailTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dbtCustAcctNum
            // 
            this.dbtCustAcctNum.Location = new System.Drawing.Point(104, 150);
            this.dbtCustAcctNum.Name = "dbtCustAcctNum";
            this.dbtCustAcctNum.Size = new System.Drawing.Size(240, 20);
            this.dbtCustAcctNum.TabIndex = 2;
            this.dbtCustAcctNum.WordWrap = false;
            // 
            // dbtCustName
            // 
            this.dbtCustName.Location = new System.Drawing.Point(104, 176);
            this.dbtCustName.Name = "dbtCustName";
            this.dbtCustName.Size = new System.Drawing.Size(240, 20);
            this.dbtCustName.TabIndex = 3;
            this.dbtCustName.WordWrap = false;
            this.dbtCustName.TextChanged += new System.EventHandler(this.dbtCustName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name/Title:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(122, 499);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Originator to Beneficiary Info (OBI)";
            // 
            // obiText
            // 
            this.obiText.AcceptsReturn = true;
            this.obiText.Location = new System.Drawing.Point(104, 515);
            this.obiText.Multiline = true;
            this.obiText.Name = "obiText";
            this.obiText.Size = new System.Drawing.Size(240, 61);
            this.obiText.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(53, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Address:";
            // 
            // dbtCustAddrOne
            // 
            this.dbtCustAddrOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbtCustAddrOne.Location = new System.Drawing.Point(104, 202);
            this.dbtCustAddrOne.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.dbtCustAddrOne.Name = "dbtCustAddrOne";
            this.dbtCustAddrOne.Size = new System.Drawing.Size(240, 20);
            this.dbtCustAddrOne.TabIndex = 4;
            this.dbtCustAddrOne.WordWrap = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(41, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 17);
            this.label12.TabIndex = 30;
            this.label12.Text = "DEBIT CUSTOMER";
            // 
            // dbtCustAddrTwo
            // 
            this.dbtCustAddrTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbtCustAddrTwo.Location = new System.Drawing.Point(104, 222);
            this.dbtCustAddrTwo.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.dbtCustAddrTwo.Name = "dbtCustAddrTwo";
            this.dbtCustAddrTwo.Size = new System.Drawing.Size(240, 20);
            this.dbtCustAddrTwo.TabIndex = 5;
            this.dbtCustAddrTwo.WordWrap = false;
            // 
            // dbtCustAddrThree
            // 
            this.dbtCustAddrThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbtCustAddrThree.Location = new System.Drawing.Point(104, 242);
            this.dbtCustAddrThree.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.dbtCustAddrThree.Name = "dbtCustAddrThree";
            this.dbtCustAddrThree.Size = new System.Drawing.Size(240, 20);
            this.dbtCustAddrThree.TabIndex = 6;
            this.dbtCustAddrThree.WordWrap = false;
            // 
            // dbtCustAddrFour
            // 
            this.dbtCustAddrFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbtCustAddrFour.Location = new System.Drawing.Point(104, 262);
            this.dbtCustAddrFour.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.dbtCustAddrFour.Name = "dbtCustAddrFour";
            this.dbtCustAddrFour.Size = new System.Drawing.Size(240, 20);
            this.dbtCustAddrFour.TabIndex = 7;
            this.dbtCustAddrFour.WordWrap = false;
            // 
            // recBankAddrFour
            // 
            this.recBankAddrFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recBankAddrFour.Location = new System.Drawing.Point(485, 262);
            this.recBankAddrFour.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.recBankAddrFour.Name = "recBankAddrFour";
            this.recBankAddrFour.Size = new System.Drawing.Size(240, 20);
            this.recBankAddrFour.TabIndex = 13;
            this.recBankAddrFour.WordWrap = false;
            // 
            // recBankAddrThree
            // 
            this.recBankAddrThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recBankAddrThree.Location = new System.Drawing.Point(485, 242);
            this.recBankAddrThree.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.recBankAddrThree.Name = "recBankAddrThree";
            this.recBankAddrThree.Size = new System.Drawing.Size(240, 20);
            this.recBankAddrThree.TabIndex = 12;
            this.recBankAddrThree.WordWrap = false;
            // 
            // recBankAddrTwo
            // 
            this.recBankAddrTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recBankAddrTwo.Location = new System.Drawing.Point(485, 222);
            this.recBankAddrTwo.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.recBankAddrTwo.Name = "recBankAddrTwo";
            this.recBankAddrTwo.Size = new System.Drawing.Size(240, 20);
            this.recBankAddrTwo.TabIndex = 11;
            this.recBankAddrTwo.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(422, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 17);
            this.label3.TabIndex = 40;
            this.label3.Text = "RECIEVING BANK DETAIL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(403, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bank Address:";
            // 
            // recBankAddrOne
            // 
            this.recBankAddrOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recBankAddrOne.Location = new System.Drawing.Point(485, 202);
            this.recBankAddrOne.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.recBankAddrOne.Name = "recBankAddrOne";
            this.recBankAddrOne.Size = new System.Drawing.Size(240, 20);
            this.recBankAddrOne.TabIndex = 10;
            this.recBankAddrOne.WordWrap = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(413, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bank Name:";
            // 
            // recBankName
            // 
            this.recBankName.Location = new System.Drawing.Point(485, 176);
            this.recBankName.Name = "recBankName";
            this.recBankName.Size = new System.Drawing.Size(240, 20);
            this.recBankName.TabIndex = 9;
            this.recBankName.WordWrap = false;
            // 
            // recBankABA
            // 
            this.recBankABA.Location = new System.Drawing.Point(485, 150);
            this.recBankABA.Name = "recBankABA";
            this.recBankABA.Size = new System.Drawing.Size(240, 20);
            this.recBankABA.TabIndex = 8;
            this.recBankABA.WordWrap = false;
            // 
            // bnfBankAddrFour
            // 
            this.bnfBankAddrFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfBankAddrFour.Location = new System.Drawing.Point(485, 453);
            this.bnfBankAddrFour.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.bnfBankAddrFour.Name = "bnfBankAddrFour";
            this.bnfBankAddrFour.Size = new System.Drawing.Size(240, 20);
            this.bnfBankAddrFour.TabIndex = 25;
            this.bnfBankAddrFour.WordWrap = false;
            // 
            // bnfBankAddrThree
            // 
            this.bnfBankAddrThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfBankAddrThree.Location = new System.Drawing.Point(485, 433);
            this.bnfBankAddrThree.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.bnfBankAddrThree.Name = "bnfBankAddrThree";
            this.bnfBankAddrThree.Size = new System.Drawing.Size(240, 20);
            this.bnfBankAddrThree.TabIndex = 24;
            this.bnfBankAddrThree.WordWrap = false;
            // 
            // bnfBankAddrTwo
            // 
            this.bnfBankAddrTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfBankAddrTwo.Location = new System.Drawing.Point(485, 413);
            this.bnfBankAddrTwo.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.bnfBankAddrTwo.Name = "bnfBankAddrTwo";
            this.bnfBankAddrTwo.Size = new System.Drawing.Size(240, 20);
            this.bnfBankAddrTwo.TabIndex = 23;
            this.bnfBankAddrTwo.WordWrap = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(422, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "BENEFICIARY BANK DETAIL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(403, 396);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Bank Address:";
            // 
            // bnfBankAddrOne
            // 
            this.bnfBankAddrOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfBankAddrOne.Location = new System.Drawing.Point(485, 393);
            this.bnfBankAddrOne.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.bnfBankAddrOne.Name = "bnfBankAddrOne";
            this.bnfBankAddrOne.Size = new System.Drawing.Size(240, 20);
            this.bnfBankAddrOne.TabIndex = 22;
            this.bnfBankAddrOne.WordWrap = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(413, 370);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Bank Name:";
            // 
            // bnfBankName
            // 
            this.bnfBankName.Location = new System.Drawing.Point(485, 367);
            this.bnfBankName.Name = "bnfBankName";
            this.bnfBankName.Size = new System.Drawing.Size(240, 20);
            this.bnfBankName.TabIndex = 21;
            this.bnfBankName.WordWrap = false;
            // 
            // bnfBankABA
            // 
            this.bnfBankABA.Location = new System.Drawing.Point(485, 341);
            this.bnfBankABA.Name = "bnfBankABA";
            this.bnfBankABA.Size = new System.Drawing.Size(240, 20);
            this.bnfBankABA.TabIndex = 20;
            this.bnfBankABA.WordWrap = false;
            // 
            // bnfCustAddrFour
            // 
            this.bnfCustAddrFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfCustAddrFour.Location = new System.Drawing.Point(104, 453);
            this.bnfCustAddrFour.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.bnfCustAddrFour.Name = "bnfCustAddrFour";
            this.bnfCustAddrFour.Size = new System.Drawing.Size(240, 20);
            this.bnfCustAddrFour.TabIndex = 19;
            this.bnfCustAddrFour.WordWrap = false;
            // 
            // bnfCustAddrThree
            // 
            this.bnfCustAddrThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfCustAddrThree.Location = new System.Drawing.Point(104, 433);
            this.bnfCustAddrThree.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.bnfCustAddrThree.Name = "bnfCustAddrThree";
            this.bnfCustAddrThree.Size = new System.Drawing.Size(240, 20);
            this.bnfCustAddrThree.TabIndex = 18;
            this.bnfCustAddrThree.WordWrap = false;
            // 
            // bnfCustAddrTwo
            // 
            this.bnfCustAddrTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfCustAddrTwo.Location = new System.Drawing.Point(104, 413);
            this.bnfCustAddrTwo.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.bnfCustAddrTwo.Name = "bnfCustAddrTwo";
            this.bnfCustAddrTwo.Size = new System.Drawing.Size(240, 20);
            this.bnfCustAddrTwo.TabIndex = 17;
            this.bnfCustAddrTwo.WordWrap = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(41, 315);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(163, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "BENEFICIARY PARTY";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(53, 396);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Address:";
            // 
            // bnfCustAddrOne
            // 
            this.bnfCustAddrOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfCustAddrOne.Location = new System.Drawing.Point(104, 393);
            this.bnfCustAddrOne.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.bnfCustAddrOne.Name = "bnfCustAddrOne";
            this.bnfCustAddrOne.Size = new System.Drawing.Size(240, 20);
            this.bnfCustAddrOne.TabIndex = 16;
            this.bnfCustAddrOne.WordWrap = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(38, 370);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Name/Title:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(11, 344);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Account Number:";
            // 
            // bnfCustName
            // 
            this.bnfCustName.Location = new System.Drawing.Point(104, 367);
            this.bnfCustName.Name = "bnfCustName";
            this.bnfCustName.Size = new System.Drawing.Size(240, 20);
            this.bnfCustName.TabIndex = 15;
            this.bnfCustName.WordWrap = false;
            // 
            // bnfCustAcctNum
            // 
            this.bnfCustAcctNum.Location = new System.Drawing.Point(104, 341);
            this.bnfCustAcctNum.Name = "bnfCustAcctNum";
            this.bnfCustAcctNum.Size = new System.Drawing.Size(240, 20);
            this.bnfCustAcctNum.TabIndex = 14;
            this.bnfCustAcctNum.WordWrap = false;
            // 
            // fedWireDirectoryLinkLabel
            // 
            this.fedWireDirectoryLinkLabel.AutoSize = true;
            this.fedWireDirectoryLinkLabel.Location = new System.Drawing.Point(633, 100);
            this.fedWireDirectoryLinkLabel.Name = "fedWireDirectoryLinkLabel";
            this.fedWireDirectoryLinkLabel.Size = new System.Drawing.Size(92, 13);
            this.fedWireDirectoryLinkLabel.TabIndex = 0;
            this.fedWireDirectoryLinkLabel.TabStop = true;
            this.fedWireDirectoryLinkLabel.Text = "FedWire Directory";
            this.fedWireDirectoryLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.fedWireDirectoryLinkLabel1_LinkClicked);
            // 
            // label18
            // 
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label18.Location = new System.Drawing.Point(7, 120);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(740, 2);
            this.label18.TabIndex = 61;
            // 
            // label19
            // 
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label19.Location = new System.Drawing.Point(9, 486);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(737, 2);
            this.label19.TabIndex = 62;
            // 
            // label20
            // 
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label20.Location = new System.Drawing.Point(7, 121);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(2, 367);
            this.label20.TabIndex = 63;
            // 
            // label21
            // 
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label21.Location = new System.Drawing.Point(379, 121);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(2, 367);
            this.label21.TabIndex = 64;
            // 
            // label22
            // 
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label22.Location = new System.Drawing.Point(745, 121);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(2, 367);
            this.label22.TabIndex = 65;
            // 
            // label23
            // 
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label23.Location = new System.Drawing.Point(8, 302);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(739, 2);
            this.label23.TabIndex = 66;
            // 
            // recBankAcctType
            // 
            this.recBankAcctType.Cursor = System.Windows.Forms.Cursors.Default;
            this.recBankAcctType.FormattingEnabled = true;
            this.recBankAcctType.Items.AddRange(new object[] {
            "ABA",
            "SWIFT"});
            this.recBankAcctType.Location = new System.Drawing.Point(406, 149);
            this.recBankAcctType.MaxDropDownItems = 2;
            this.recBankAcctType.Name = "recBankAcctType";
            this.recBankAcctType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.recBankAcctType.Size = new System.Drawing.Size(73, 21);
            this.recBankAcctType.TabIndex = 0;
            this.recBankAcctType.TabStop = false;
            this.recBankAcctType.Text = "ABA";
            // 
            // bnfBankAcctType
            // 
            this.bnfBankAcctType.Cursor = System.Windows.Forms.Cursors.Default;
            this.bnfBankAcctType.FormattingEnabled = true;
            this.bnfBankAcctType.Items.AddRange(new object[] {
            "ABA"});
            this.bnfBankAcctType.Location = new System.Drawing.Point(406, 340);
            this.bnfBankAcctType.MaxDropDownItems = 2;
            this.bnfBankAcctType.Name = "bnfBankAcctType";
            this.bnfBankAcctType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bnfBankAcctType.Size = new System.Drawing.Size(73, 21);
            this.bnfBankAcctType.TabIndex = 0;
            this.bnfBankAcctType.TabStop = false;
            this.bnfBankAcctType.Text = "ABA";
            // 
            // wireFormSubmit
            // 
            this.wireFormSubmit.Enabled = false;
            this.wireFormSubmit.Location = new System.Drawing.Point(670, 553);
            this.wireFormSubmit.Name = "wireFormSubmit";
            this.wireFormSubmit.Size = new System.Drawing.Size(75, 23);
            this.wireFormSubmit.TabIndex = 28;
            this.wireFormSubmit.Text = "Submit";
            this.wireFormSubmit.UseVisualStyleBackColor = true;
            this.wireFormSubmit.Click += new System.EventHandler(this.wireFormSubmit_Click);
            // 
            // wireIDNum
            // 
            this.wireIDNum.AutoSize = true;
            this.wireIDNum.Location = new System.Drawing.Point(605, 57);
            this.wireIDNum.Name = "wireIDNum";
            this.wireIDNum.Size = new System.Drawing.Size(0, 13);
            this.wireIDNum.TabIndex = 69;
            this.wireIDNum.Tag = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(540, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 0;
            this.label13.Tag = "0";
            this.label13.Text = "Wire ID#:";
            // 
            // wireFormVerify
            // 
            this.wireFormVerify.Location = new System.Drawing.Point(589, 553);
            this.wireFormVerify.Name = "wireFormVerify";
            this.wireFormVerify.Size = new System.Drawing.Size(75, 23);
            this.wireFormVerify.TabIndex = 27;
            this.wireFormVerify.Text = "Lock In";
            this.wireFormVerify.UseVisualStyleBackColor = true;
            this.wireFormVerify.Click += new System.EventHandler(this.wireFormVerify_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(248, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "AMOUNT:";
            // 
            // wireAmt
            // 
            this.wireAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wireAmt.Location = new System.Drawing.Point(318, 71);
            this.wireAmt.MaxLength = 12;
            this.wireAmt.Name = "wireAmt";
            this.wireAmt.Size = new System.Drawing.Size(138, 20);
            this.wireAmt.TabIndex = 1;
            this.wireAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.wireAmt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.wireAmt_KeyPress);
            this.wireAmt.Leave += new System.EventHandler(this.wireAmt_Leave);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(561, 76);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(32, 13);
            this.label24.TabIndex = 70;
            this.label24.Tag = "0";
            this.label24.Text = "User:";
            // 
            // activeUser
            // 
            this.activeUser.AutoSize = true;
            this.activeUser.Location = new System.Drawing.Point(605, 76);
            this.activeUser.Name = "activeUser";
            this.activeUser.Size = new System.Drawing.Size(0, 13);
            this.activeUser.TabIndex = 71;
            this.activeUser.Tag = "0";
            // 
            // wireTypeSelect
            // 
            this.wireTypeSelect.DropDownWidth = 450;
            this.wireTypeSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wireTypeSelect.FormatString = "N0";
            this.wireTypeSelect.FormattingEnabled = true;
            this.wireTypeSelect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.wireTypeSelect.Items.AddRange(new object[] {
            "1000 - Funds Transfer Basic",
            "1001 - Funds Transfer Reversal Request (Same Day)",
            "1002 - Funds Transfer Reversal (Same Day)",
            "1007 - Funds Transfer Reversal Request (Prior Day)",
            "1008 - Funds Transfer Reversal (Prior Day)",
            "1031 - Funds Transfer Request for Credit (Drawdown)",
            "1032 - Funds Transfer Honoring Request for Credit (Drawdown)",
            "1033 - Refusal to Honor a Request for Credit (Drawdown)",
            "1090 - Service Message",
            "1500 - Foreign Funds Transfer Basic",
            "1501 - Foreign Funds Transfer Reversal Request (Same Day)",
            "1502 - Foreign Funds Transfer Reversal (Same Day)",
            "1507 - Foreign Funds Transfer Reversal Request (Prior Day)",
            "1508 - Foreign Funds Transfer Reversal (Prior Day)",
            "1531 - Foreign Funds Transfer Request for Credit (Drawdown)",
            "1532 - Foreign Funds Transfer Honoring Request for Credit (Drawdown)",
            "1533 - Foreign Refusal to Honor a Request for Credit (Drawdown)",
            "1590 - Foreign Service Message",
            "1600 - Bank-to-Bank Funds Transfer Basic",
            "1601 - Bank-to-Bank Funds Transfer Reversal Request (Same Day)",
            "1602 - Bank-to-Bank Funds Transfer Reversal (Same Day)",
            "1607 - Bank-to-Bank Funds Transfer Reversal Request (Prior Day)",
            "1608 - Bank-to-Bank Funds Transfer Reversal (Prior Day)",
            "1631 - Bank-to-Bank Funds Transfer Request for Credit (Drawdown)",
            "1632 - Bank-to-Bank Funds Transfer Honoring Request for Credit (Drawdown)",
            "1633 - Bank-to-Bank Refusal to Honor a Request for Credit (Drawdown)",
            "1690 - Bank-to-Bank Service Message"});
            this.wireTypeSelect.Location = new System.Drawing.Point(179, 97);
            this.wireTypeSelect.MaxLength = 4;
            this.wireTypeSelect.Name = "wireTypeSelect";
            this.wireTypeSelect.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.wireTypeSelect.Size = new System.Drawing.Size(400, 21);
            this.wireTypeSelect.TabIndex = 0;
            this.wireTypeSelect.TabStop = false;
            this.wireTypeSelect.Text = "1000 - Funds Transfer Basic";
            this.wireTypeSelect.Leave += new System.EventHandler(this.wireTypeSelect_Leave);
            // 
            // domesticWireHeaderMenu
            // 
            this.domesticWireHeaderMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.domesticWireHeaderMenu.Location = new System.Drawing.Point(0, 0);
            this.domesticWireHeaderMenu.Name = "domesticWireHeaderMenu";
            this.domesticWireHeaderMenu.Size = new System.Drawing.Size(754, 24);
            this.domesticWireHeaderMenu.TabIndex = 72;
            this.domesticWireHeaderMenu.Text = "domesticWireHeaderMenu";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openTemplateToolStripMenuItem,
            this.saveTemplateToolStripMenuItem,
            this.closeWindowToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "&File";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // openTemplateToolStripMenuItem
            // 
            this.openTemplateToolStripMenuItem.Name = "openTemplateToolStripMenuItem";
            this.openTemplateToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.openTemplateToolStripMenuItem.Text = "&Open Template";
            // 
            // saveTemplateToolStripMenuItem
            // 
            this.saveTemplateToolStripMenuItem.Name = "saveTemplateToolStripMenuItem";
            this.saveTemplateToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.saveTemplateToolStripMenuItem.Text = "&Save As Template";
            // 
            // closeWindowToolStripMenuItem
            // 
            this.closeWindowToolStripMenuItem.Name = "closeWindowToolStripMenuItem";
            this.closeWindowToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.closeWindowToolStripMenuItem.Text = "E&xit";
            this.closeWindowToolStripMenuItem.Click += new System.EventHandler(this.closeWindowToolStripMenuItem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(546, 38);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(47, 13);
            this.label25.TabIndex = 73;
            this.label25.Text = "Initiated:";
            // 
            // initiatedTime
            // 
            this.initiatedTime.AutoSize = true;
            this.initiatedTime.Location = new System.Drawing.Point(605, 38);
            this.initiatedTime.Name = "initiatedTime";
            this.initiatedTime.Size = new System.Drawing.Size(0, 13);
            this.initiatedTime.TabIndex = 74;
            // 
            // DomesticWireFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(754, 586);
            this.Controls.Add(this.initiatedTime);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.wireTypeSelect);
            this.Controls.Add(this.activeUser);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.wireAmt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.wireFormVerify);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.wireIDNum);
            this.Controls.Add(this.wireFormSubmit);
            this.Controls.Add(this.bnfBankAcctType);
            this.Controls.Add(this.recBankAcctType);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.fedWireDirectoryLinkLabel);
            this.Controls.Add(this.bnfCustAddrFour);
            this.Controls.Add(this.bnfCustAddrThree);
            this.Controls.Add(this.bnfCustAddrTwo);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.bnfCustAddrOne);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.bnfCustName);
            this.Controls.Add(this.bnfCustAcctNum);
            this.Controls.Add(this.bnfBankAddrFour);
            this.Controls.Add(this.bnfBankAddrThree);
            this.Controls.Add(this.bnfBankAddrTwo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bnfBankAddrOne);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bnfBankName);
            this.Controls.Add(this.bnfBankABA);
            this.Controls.Add(this.recBankAddrFour);
            this.Controls.Add(this.recBankAddrThree);
            this.Controls.Add(this.recBankAddrTwo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.recBankAddrOne);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.recBankName);
            this.Controls.Add(this.recBankABA);
            this.Controls.Add(this.dbtCustAddrFour);
            this.Controls.Add(this.dbtCustAddrThree);
            this.Controls.Add(this.dbtCustAddrTwo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dbtCustAddrOne);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.obiText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dbtCustName);
            this.Controls.Add(this.dbtCustAcctNum);
            this.Controls.Add(this.FedWireDetailTitle);
            this.Controls.Add(this.domesticWireHeaderMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.domesticWireHeaderMenu;
            this.Name = "DomesticWireFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FedWire File Creator";
            this.Load += new System.EventHandler(this.DomesticWireForm);
            this.domesticWireHeaderMenu.ResumeLayout(false);
            this.domesticWireHeaderMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FedWireDetailTitle;
        private System.Windows.Forms.TextBox dbtCustAcctNum;
        private System.Windows.Forms.TextBox dbtCustName;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox obiText;
        public System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox dbtCustAddrOne;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox dbtCustAddrTwo;
        private System.Windows.Forms.TextBox dbtCustAddrThree;
        private System.Windows.Forms.TextBox dbtCustAddrFour;
        private System.Windows.Forms.TextBox recBankAddrFour;
        private System.Windows.Forms.TextBox recBankAddrThree;
        private System.Windows.Forms.TextBox recBankAddrTwo;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox recBankAddrOne;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox recBankName;
        private System.Windows.Forms.TextBox recBankABA;
        private System.Windows.Forms.TextBox bnfBankAddrFour;
        private System.Windows.Forms.TextBox bnfBankAddrThree;
        private System.Windows.Forms.TextBox bnfBankAddrTwo;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox bnfBankAddrOne;
        public System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox bnfBankName;
        private System.Windows.Forms.TextBox bnfBankABA;
        private System.Windows.Forms.TextBox bnfCustAddrFour;
        private System.Windows.Forms.TextBox bnfCustAddrThree;
        private System.Windows.Forms.TextBox bnfCustAddrTwo;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox bnfCustAddrOne;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox bnfCustName;
        private System.Windows.Forms.TextBox bnfCustAcctNum;
        private System.Windows.Forms.LinkLabel fedWireDirectoryLinkLabel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox recBankAcctType;
        private System.Windows.Forms.ComboBox bnfBankAcctType;
        private System.Windows.Forms.Button wireFormSubmit;
        private System.Windows.Forms.Label wireIDNum;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button wireFormVerify;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox wireAmt;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label activeUser;
        private System.Windows.Forms.ComboBox wireTypeSelect;
        private System.Windows.Forms.MenuStrip domesticWireHeaderMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openTemplateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTemplateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeWindowToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;

        public System.Collections.Generic.List<TextBox> textBoxList = new System.Collections.Generic.List<TextBox>();
        private Label initiatedTime;
        private Label label25;
    }
}

