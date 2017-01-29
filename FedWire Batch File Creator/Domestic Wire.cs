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
        Wire currentWire = new Wire();

        public DomesticWireForm()
        {
            InitializeComponent();
            Debug.WriteLine("Opening DomesticWireForm");
            AssociateDomesticWireTextBoxes();
        }

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




        }

        private void wireFormSubmit_Click(object sender, EventArgs e)
        {
            if (verifyRequiredTextBoxes())
            {
                RelateTextBoxInfo(currentWire);
                currentWire.UpdateWireDB();
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
                currentWire.Status = "VERF";
                toggleLockAllFields(isUnlocked: false);
                wireFormVerify.Text = "Edit Wire";
                debugTextBoxValues();
            }
            else
            {
                currentWire.Status = "UNVF";
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
            if (currentWire.Status == "UNVF") 
            {
                currentWire.DestroyAllDBRef();
            }
        }
    }
}
