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
        }

        private void DomesticWireForm(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Opening DomesticWireFrm");
            associateDefaultWireValues();
            associateDefaultTextBoxes();
        }

        private void associateDefaultTextBoxes()
        {
            textBoxList.Add(wireAmt);
            textBoxList.Add(dbtCustAcctNum);
            textBoxList.Add(dbtCustName);
            textBoxList.Add(dbtCustAddrOne);
            textBoxList.Add(dbtCustAddrTwo);
            textBoxList.Add(dbtCustAddrThree);
            textBoxList.Add(dbtCustAddrFour);
            textBoxList.Add(recBankABA);
            textBoxList.Add(recBankName);
            textBoxList.Add(recBankAddrOne);
            textBoxList.Add(recBankAddrTwo);
            textBoxList.Add(recBankAddrThree);
            textBoxList.Add(recBankAddrFour);
            textBoxList.Add(bnfBankABA);
            textBoxList.Add(bnfBankName);
            textBoxList.Add(bnfBankAddrOne);
            textBoxList.Add(bnfBankAddrTwo);
            textBoxList.Add(bnfBankAddrThree);
            textBoxList.Add(bnfBankAddrFour);
            textBoxList.Add(bnfCustAcctNum);
            textBoxList.Add(bnfCustAddrOne);
            textBoxList.Add(bnfCustAddrTwo);
            textBoxList.Add(bnfCustAddrThree);
            textBoxList.Add(bnfCustAddrFour);
            textBoxList.Add(obiTextOne);
            textBoxList.Add(obiTextTwo);
            textBoxList.Add(obiTextThree);
            textBoxList.Add(obiTextFour);
            System.Diagnostics.Debug.WriteLine("Finished Writing {0} TextBoxes to textBoxList", textBoxList.Count);
        }

        private void associateDefaultWireValues()
        {
            initiatedTime.Text = DateTime.Now.ToString();
            wireIDNum.Text = "00001 Placeholder";
            activeUser.Text = "Test User";
        }

        private void wireFormSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicking this will save the wire to the database");
        }

        private void toggleLockAllFields(bool isUnlocked)
        {
            for (int boxnum = 0; boxnum < textBoxList.Count; boxnum++)
            {
                textBoxList[boxnum].Enabled = isUnlocked;
            }

            wireTypeSelect.Enabled = isUnlocked;
            recBankAcctType.Enabled = isUnlocked;
            bnfBankAcctType.Enabled = isUnlocked;
            wireFormSubmit.Enabled = !isUnlocked;
            clearAllButton.Enabled = isUnlocked;
        }

        private void wireFormVerify_Click(object sender, EventArgs e)
        {
            if (wireFormVerify.Text == "Lock In")
            {
                toggleLockAllFields(isUnlocked: false);
                toggleAssociateWireDetail(confirmed: true);
                wireFormVerify.Text = "Edit Wire";
                debugTextBoxValues();
            }
            else
            {
                toggleLockAllFields(isUnlocked: true);
                toggleAssociateWireDetail(confirmed: false);
                wireFormVerify.Text = "Lock In";
            }
        }

        private void toggleAssociateWireDetail(bool confirmed)
        {
            // Will be used to Associate the current fields to the class.
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

        private void dbtCustAcctNum_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void wireAmt_Leave(object sender, EventArgs e)
        {
            if (wireAmt.Text != "")
            {
                wireAmt.Text = string.Format("{0:C2}", decimal.Parse(wireAmt.Text, System.Globalization.NumberStyles.Currency));
            }
        }
    }
}
