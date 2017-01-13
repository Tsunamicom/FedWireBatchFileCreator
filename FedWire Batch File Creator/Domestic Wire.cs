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


namespace FedWire_Batch_File_Creator
{
    public partial class DomesticWireFrm : Form
    {
        Wire currentWire = new Wire();

        public DomesticWireFrm()
        {
            InitializeComponent();
        }

        private void DomesticWireForm(object sender, EventArgs e)
        {
            associateDefaultWireValues();
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
            textBoxList.Add(obiText);
            
        }

        private void associateDefaultWireValues()
        {
            currentWire.initiatorName = "Test Dummy"; // User Profile Name (Temporary)
            activeUser.Text = currentWire.initiatorName;

            currentWire.wireID = 00000001; // Next Database ID (Temporary)
            wireIDNum.Text = currentWire.wireID.ToString();
        }

        private void wireFormSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(currentWire.WireAmount.FieldValue);
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

        private void wireTypeSelect_Leave(object sender, EventArgs e)
        {
            currentWire.WireType.FieldValue = wireTypeSelect.Text.Substring(0, 4);
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

        private void convertToDecimal_KeyPress(TextBox numberTextBox, KeyPressEventArgs e)
        {
            int periodIndex = numberTextBox.Text.IndexOf('.');
            e.Handled = !(char.IsNumber(e.KeyChar)
            || (e.KeyChar == '.' && periodIndex == -1)
            || e.KeyChar == ','
            || e.KeyChar == (char)Keys.Back);

            if (e.KeyChar == (char)Keys.Enter)
            {
                numberTextBox.Text = string.Format("{0:n2}", double.Parse(numberTextBox.Text));
            }
        }

        private void wireAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            convertToDecimal_KeyPress(wireAmt, e);
        }

        private bool verifyUSCurrencyField(TextBox form)
        {
            Regex pattern = new Regex(@"^[0-9]{1,10}[.\]*[0-9]{0,3}$");
            return pattern.IsMatch(form.Text);
        }

        private bool verifyAllAlpha(TextBox form, int length)
        {
            Regex pattern = new Regex(@"^[A-Za-z ]{1," + length.ToString() + "}");
            return pattern.IsMatch(form.Text);
        }

        private void wireAmt_Leave(object sender, EventArgs e)
        {

        }

        private void dbtCustName_TextChanged(object sender, EventArgs e)
        {
            if (verifyAllAlpha(dbtCustName, 35) == true)
            {
                currentWire.Originator.FieldValue = dbtCustName.Text;
            }
            else
            {
                currentWire.Originator.FieldValue = null;
            }
        }

        private void closeWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit without Saving?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
            
        }
    }
}
