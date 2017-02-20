using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Diagnostics;


namespace FedWire_Batch_File_Creator
{
    public partial class DomesticWireForm : Form
    {
        public UserAccess CurrentUser = new UserAccess();
        public Wire CurrentWire { get; set; }

        public DomesticWireForm(UserAccess activeUser, int currentBatchID)
        {
            CurrentUser = activeUser;
            CurrentWire = new Wire(activeUser, currentBatchID);
            InitializeComponent();
            Debug.WriteLine("DOMESTICWIREFORM: Opening DomesticWireForm");
            AssociateDomesticWireTextBoxes();
            AssignDefaultWireInfo();
            DisplayDefaultWireInfo();
            Debug.WriteLine("DOMESTICWIREFORM: Current User => " + activeUser.thisUser.UserName);
            Debug.WriteLine("DOMESTICWIREFORM: Current Batch => " + currentBatchID);
        }
        
        /// <summary>
        /// Assigns various TextBox and Label values to display to the user in order to facilitate a clean user experience.
        /// </summary>
        private void DisplayDefaultWireInfo()
        {
            initiatedTime.Text = CurrentWire.InitiatedByDateTime.ToString();
            wireIDNum.Text = CurrentWire.WireID.ToString();
            activeUser.Text = CurrentUser.thisUser.First_Name + " " + CurrentUser.thisUser.Last_Name;
            wireTypeSelect.SelectedIndex = 0;
            batchID.Text = CurrentWire.FK_BatchID.ToString();
        }

        /// <summary>
        /// Assigns various Default Values to the Wire class object
        /// </summary>
        private void AssignDefaultWireInfo()
        {
            CurrentWire.InitiatedByUser = CurrentUser.thisUser.UserName;
            CurrentWire.ModifiedByUser = CurrentUser.thisUser.UserName;
        }

        /// <summary>
        /// Adds the appropriate TextBoxes to textBoxList in order to manipulate all items in the list.
        /// </summary>
        private void AssociateDomesticWireTextBoxes()
        {
            textBoxList.Add(wireAmt);
            textBoxList.Add(dbtCustAcctNum);
            textBoxList.Add(dbtCustName);
            textBoxList.Add(dbtCustAddrOne);
            textBoxList.Add(dbtCustAddrTwo);
            textBoxList.Add(dbtCustAddrThree);
            textBoxList.Add(interBankABA);
            textBoxList.Add(interBankName);
            textBoxList.Add(interBankAddrOne);
            textBoxList.Add(interBankAddrTwo);
            textBoxList.Add(interBankAddrThree);
            textBoxList.Add(bnfBankABA);
            textBoxList.Add(bnfBankName);
            textBoxList.Add(bnfBankAddrOne);
            textBoxList.Add(bnfBankAddrTwo);
            textBoxList.Add(bnfBankAddrThree);
            textBoxList.Add(bnfCustAcctNum);
            textBoxList.Add(bnfCustName);
            textBoxList.Add(bnfCustAddrOne);
            textBoxList.Add(bnfCustAddrTwo);
            textBoxList.Add(bnfCustAddrThree);
            textBoxList.Add(obiTextOne);
            textBoxList.Add(obiTextTwo);
            textBoxList.Add(obiTextThree);
            textBoxList.Add(obiTextFour);
            System.Diagnostics.Debug.WriteLine("Finished Writing {0} TextBoxes to textBoxList", textBoxList.Count);
        }

        /// <summary>
        /// Assigns the Values of the form to the Wire class object
        /// </summary>
        /// <param name="wire"></param>
        private void RelateTextBoxInfo(Wire wire)
        {
            // Mandatory Info
            wire.TypeCode = wireTypeSelect.Text.Substring(0, 2);
            wire.SubType = wireTypeSelect.Text.Substring(2, 2);
            wire.WireAmount = decimal.Parse(string.Join("", wireAmt.Text.Where(char.IsDigit))).ToString("000000000000").Substring(0,12);
            wire.BusinessFunctionCode = "CTR";

            // Debit Customer
            wire.Orig_ID = "D"; // "D" for DDA Account (default for this form)
            wire.Orig_Ident = dbtCustAcctNum.Text;
            wire.Orig_Name = dbtCustName.Text;
            wire.Orig_Addr1 = dbtCustAddrOne.Text;
            wire.Orig_Addr2 = dbtCustAddrTwo.Text;
            wire.Orig_Addr3 = dbtCustAddrThree.Text;

            // Intermediary Bank Detail (NOT Required)
            if (interBankABA.Text != null)
            {
                wire.InterFI_ID = "F"; // "F" for Fed Routing Number (default for this form)
                wire.InterFI_Ident = interBankABA.Text;
                wire.InterFI_Name = interBankName.Text;
                wire.InterFI_Addr1 = interBankAddrOne.Text;
                wire.InterFI_Addr2 = interBankAddrTwo.Text;
                wire.InterFI_Addr3 = interBankAddrThree.Text;
            }

            // Beneficiary Party
            wire.Bnf_ID = "D"; // "D" is for DDA Account (default for this form)
            wire.Bnf_Ident = bnfCustAcctNum.Text;
            wire.Bnf_Name = bnfCustName.Text;
            wire.Bnf_Addr1 = bnfCustAddrOne.Text;
            wire.Bnf_Addr2 = bnfCustAddrTwo.Text;
            wire.Bnf_Addr3 = bnfCustAddrThree.Text;

            // Beneficiary Bank Detail
            wire.BenFI_ID = "F"; // "F" is for Fed Routing Number (default for this form)
            wire.BenFI_Ident = bnfBankABA.Text;
            wire.BenFI_Name = bnfBankName.Text;
            wire.BenFI_Addr1 = bnfBankAddrOne.Text;
            wire.BenFI_Addr2 = bnfBankAddrTwo.Text;
            wire.BenFI_Addr3 = bnfBankAddrThree.Text;

            // Originator to Beneficiary Infomation (OBI)
            wire.OBI_L1 = obiTextOne.Text;
            wire.OBI_L2 = obiTextTwo.Text;
            wire.OBI_L3 = obiTextThree.Text;
            wire.OBI_L4 = obiTextFour.Text;
        }

        private void wireFormSubmit_Click(object sender, EventArgs e)
        {
            if (verifyRequiredTextBoxes())
            {
                RelateTextBoxInfo(CurrentWire);
                CurrentWire.Status = "SBMT";
                CurrentWire.UpdateWireDB();
                MessageBox.Show("Wire Submitted!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Some Required Fields are Blank!");
            }
            
        }

        private void toggleLockAllFields(bool isUnlocked)
        {
            for (int boxnum = 0; boxnum < textBoxList.Count; boxnum++)
            {
                textBoxList[boxnum].Enabled = isUnlocked;
            }

            wireTypeSelect.Enabled = isUnlocked;
            interBankAcctType.Enabled = isUnlocked;
            bnfBankAcctType.Enabled = isUnlocked;
            wireFormSubmit.Enabled = !isUnlocked;
            clearAllButton.Enabled = isUnlocked;
        }

        private void wireFormVerify_Click(object sender, EventArgs e)
        {
            if (wireFormVerify.Text == "Lock In")
            {
                CurrentWire.Status = "VERF";
                toggleLockAllFields(isUnlocked: false);
                wireFormVerify.Text = "Edit Wire";
                debugTextBoxValues();
            }
            else
            {
                CurrentWire.Status = "UNVF";
                toggleLockAllFields(isUnlocked: true);
                wireFormVerify.Text = "Lock In";
            }
        }

        private void wireAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            int periodIndex = wireAmt.Text.IndexOf('.');
            e.Handled = !(char.IsNumber(e.KeyChar)
            || (e.KeyChar == '.' && periodIndex == -1)
            || e.KeyChar == ','
            || e.KeyChar == (char)Keys.Back);
        }

        private void closeWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit without Saving?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Displays Debug info for (Names, Values) in textBoxList
        /// </summary>
        private void debugTextBoxValues()
        {
            System.Diagnostics.Debug.WriteLine("**** TEXTBOX VALUE DEBUG START {0} ****", DateTime.Now);
            for (int boxnum = 0; boxnum < textBoxList.Count; boxnum++)
            {
                System.Diagnostics.Debug.WriteLine("  Textbox {0} value: {1}", textBoxList[boxnum].Name, textBoxList[boxnum].Text);
            }
            System.Diagnostics.Debug.WriteLine("**** END TEXTBOX VALUE DEBUG ****");
        }

        private void fedWireDirectoryLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fedWireDirectoryLinkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start(@"https://www.frbservices.org/EPaymentsDirectory/searchFedwire.html");
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            for (int boxnum = 0; boxnum < textBoxList.Count; boxnum++)
            {
                textBoxList[boxnum].Text = null;
            }
        }

        private void wireAmt_Leave(object sender, EventArgs e)
        {
            if (wireAmt.Text != "")
            {
                wireAmt.Text = string.Format("{0:C2}", decimal.Parse(wireAmt.Text, System.Globalization.NumberStyles.Currency));
                wireAmt.Text = decimal.Parse(string.Join("", wireAmt.Text.Where(char.IsDigit))).ToString("000000000000").Substring(0, 12).Insert(10,".");
                wireAmt.Text = string.Format("{0:C2}", decimal.Parse(wireAmt.Text, System.Globalization.NumberStyles.Currency));
            }
        }

        private bool isNotEmptyTextBox(TextBox tbox)
        {
            if (String.IsNullOrEmpty(tbox.Text))
            {
                return false;
            }
            return true;
        }

        private bool verifyRequiredTextBoxes()
        {
            if (isNotEmptyTextBox(wireAmt)
                && isNotEmptyTextBox(dbtCustAcctNum)
                && isNotEmptyTextBox(dbtCustName)
                && isNotEmptyTextBox(bnfBankABA)
                && isNotEmptyTextBox(bnfBankName)
                && isNotEmptyTextBox(bnfCustAcctNum)
                && isNotEmptyTextBox(bnfCustName))
            {
                return true;
            }
            return false;
        }

        private void DomesticWireForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CurrentWire.Status == "UNVF") 
            {
                CurrentWire.DestroyAllDBRef();
            }
        }
    }
}
