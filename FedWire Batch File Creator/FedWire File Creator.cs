using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FedWire_Batch_File_Creator
{
    public partial class MainWindow : Form
    {
        Wire currentWire = new Wire();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void DomesticWireForm(object sender, EventArgs e)
        {
            
            // Associate the Default Values for the Wire Form Type
            associateDefaultWireValues();
            
            
        }

        private void associateDefaultWireValues()
        {
            currentWire.initiatorName = "Test Dummy"; // User Profile Name
            activeUser.Text = currentWire.initiatorName;

            currentWire.wireID = 00000001; // Next Database ID
            wireIDNum.Text = currentWire.wireID.ToString();
            
        }

        private void wireFormSubmit_Click(object sender, EventArgs e)
        {

        }

        public string validateTextAsNumber(TextBox currentForm, string wireField)
        {
            for (int i = 0; i < currentForm.Text.Length; i++)
            {
                byte testnum;
                if (byte.TryParse(currentForm.Text[i].ToString(), out testnum))
                {
                    wireField = currentForm.Text;
                }
                else
                {
                    wireField = "Invalid";
                }
            }
            return wireField;
        }

        private void dbtCustAcctNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void wireAmt_TextChanged(object sender, EventArgs e)
        {

        }

        private void wireTypeSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void wireTypeSelect_Leave(object sender, EventArgs e)
        {
            currentWire.WireType.FieldValue = wireTypeSelect.Text.Substring(0, 4);
        }

        private void toggleLockAllFields(bool isUnlocked)
        {
            wireTypeSelect.Enabled = isUnlocked;
            wireAmt.Enabled = isUnlocked;
            dbtCustAcctNum.Enabled = isUnlocked;
            dbtCustName.Enabled = isUnlocked;
            dbtCustAddrOne.Enabled = isUnlocked;
            dbtCustAddrTwo.Enabled = isUnlocked;
            dbtCustAddrThree.Enabled = isUnlocked;
            dbtCustAddrFour.Enabled = isUnlocked;
            recBankABA.Enabled = isUnlocked;
            recBankAcctType.Enabled = isUnlocked;
            recBankName.Enabled = isUnlocked;
            recBankAddrOne.Enabled = isUnlocked;
            recBankAddrTwo.Enabled = isUnlocked;
            recBankAddrThree.Enabled = isUnlocked;
            recBankAddrFour.Enabled = isUnlocked;
            bnfBankABA.Enabled = isUnlocked;
            bnfBankAcctType.Enabled = isUnlocked;
            bnfBankName.Enabled = isUnlocked;
            bnfBankAddrOne.Enabled = isUnlocked;
            bnfBankAddrTwo.Enabled = isUnlocked;
            bnfBankAddrThree.Enabled = isUnlocked;
            bnfBankAddrFour.Enabled = isUnlocked;
            bnfCustAcctNum.Enabled = isUnlocked;
            bnfCustName.Enabled = isUnlocked;
            bnfCustAddrOne.Enabled = isUnlocked;
            bnfCustAddrTwo.Enabled = isUnlocked;
            bnfCustAddrThree.Enabled = isUnlocked;
            bnfCustAddrFour.Enabled = isUnlocked;
            obiText.Enabled = isUnlocked;
            wireFormSubmit.Enabled = !isUnlocked;
        }

        private void wireFormVerify_Click(object sender, EventArgs e)
        {
            if (wireFormVerify.Text == "Lock In")
            {
                toggleLockAllFields(isUnlocked: false);
                toggleAssociateWireDetail(confirmed: true);
                wireFormVerify.Text = "Edit Wire";
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

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void wireAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char amt = e.KeyChar;
            if (!Char.IsDigit(amt) && amt != 8 && amt != 46)
            {
                e.Handled = true;
            }
        }

        private void wireAmt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(wireAmt.Text))
            {
                e.Cancel = true;
                wireAmt.Focus();
                errorProvider1.SetError(wireAmt, "Required: Amount");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(wireAmt, "");
            }
        }
    }
}
