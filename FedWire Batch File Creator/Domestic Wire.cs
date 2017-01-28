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
    public partial class DomesticWireFrm : Form
    {
        public DomesticWireFrm()
        {
            InitializeComponent();
            System.Diagnostics.Debug.WriteLine("Opening DomesticWireFrm");
            AssociateDomesticWireTextBoxes();
            Wire currentWire = new Wire();
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

        private string getNewSeqNum(int batchid, int wireid)
        {
            return batchid.ToString("000") + wireid.ToString("000");
        }

        private void wireFormSubmit_Click(object sender, EventArgs e)
        {
            if (verifyRequiredTextBoxes())
            {
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
                toggleLockAllFields(isUnlocked: false);
                wireFormVerify.Text = "Edit Wire";
                debugTextBoxValues();
            }
            else
            {
                toggleLockAllFields(isUnlocked: true);
                wireFormVerify.Text = "Lock In";
            }
        }

        private void allowedKeysAmtField(TextBox numberTextBox, KeyPressEventArgs e)
        {
            int periodIndex = numberTextBox.Text.IndexOf('.');
            e.Handled = !(char.IsNumber(e.KeyChar)
            || (e.KeyChar == '.' && periodIndex == -1)
            || e.KeyChar == ','
            || e.KeyChar == (char)Keys.Back);
        }

        private void wireAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            allowedKeysAmtField(wireAmt, e);
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

    }
}
