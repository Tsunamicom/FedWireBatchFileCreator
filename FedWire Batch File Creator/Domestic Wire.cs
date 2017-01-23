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
        string username = "TestUser";
        int domWireIDNum;
        int domBatchIDNum;
        string myBankABA = "12345679";
        //string myBankName = "The Bank of Testing";
        string myBankShortName = "BANK OF TEST";
        string recBankABA;
        string recBankShortName;
        string defaultBusFuncCode = "CTR";

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

        private void associateDefaultWireValues()
        {
            
            using (FWFCdbEntities domesticWireStart = new FWFCdbEntities())
            {
                Batch newbatch = domesticWireStart.Batches.Add(
                    new Batch
                    {
                        Opened_Time = DateTime.Now,
                        Opened_User = username,
                        OFAC_Verified = false
                    });
                Debug.WriteLine("New Batch Created");

                WireMain newwire = domesticWireStart.WireMains.Add(
                    new WireMain
                    {
                        Init_DateTime = DateTime.Now,
                        Init_UserName = username,
                        Status = "UNVR",
                        FK_BatchID = newbatch.BatchID
                    });
                domesticWireStart.SaveChanges();
                domWireIDNum = newwire.WireID;
                domBatchIDNum = newbatch.BatchID;
            }

            initiatedTime.Text = DateTime.Now.ToString();
            wireIDNum.Text = domWireIDNum.ToString();
            activeUser.Text = username;
            batchID.Text = domBatchIDNum.ToString();
        }

        private void determineRecieverBankABA()
        {
            if (interBankABA != null)
            {
                recBankABA = interBankABA.Text;
                recBankShortName = interBankName.Text;
            }
            else
            {
                recBankABA = bnfBankABA.Text;
                recBankShortName = bnfBankName.Text;
            }

            // Truncate to 18 characters max
            recBankShortName = recBankShortName.Substring(0, Math.Min(recBankShortName.Length, 18));
        }

        private void updateDomesticWireDetail()
        {
            determineRecieverBankABA();
            using (FWFCdbEntities domesticWireUpdate = new FWFCdbEntities())
            {
                var thiswire = domesticWireUpdate.WireMains.Where(w => w.WireID == domWireIDNum).FirstOrDefault();
                thiswire.Status = "SBMT";
                thiswire.Modified_DateTime = DateTime.Now;
                thiswire.Modified_UserName = username;
                thiswire.Verify_DateTime = DateTime.Now;
                thiswire.Verify_UserName = username;

                domesticWireUpdate.MandatoryFields.Add(new MandatoryField
                {
                    // {1500} Sender Supplied Information
                    SSI_Format = "30",  // Constant 30 (based on FedWire version)
                    SSI_URC = myBankABA,  // Typically an ABA or other bank designation
                    SSI_TPC = "P",  // T for Test, P for Production
                    SSI_MDC = " ", // Space for Original, P for Resend

                    // {1510} Type/SubType
                    TypeCode = wireTypeSelect.Text.Substring(0, 2),
                    SubType = wireTypeSelect.Text.Substring(2, 2),

                    // {1520} Input Message Accountability Data (IMAD)
                    IMAD_ICD = DateTime.Now.ToString("yyyyMMdd"),
                    IMAD_Source = "ABCD1234", // Typically a value designated by Fed - Placeholder
                    IMAD_Seq = getNewSeqNum(domBatchIDNum, domWireIDNum),  // Format specified by bank

                    // {2000} Amount
                    WireAmount = decimal.Parse(wireAmt.Text, System.Globalization.NumberStyles.Currency).ToString("000000000000"),

                    // {3100}
                    SenderDI_ABA = myBankABA,
                    SenderDI_ShortName = myBankShortName,

                    // {3400}
                    ReceiverDI_ABA = recBankABA,
                    ReceiverDI_ShortName = recBankShortName,

                    // {3600} Business Function Code
                    BusinessFunctionCode = defaultBusFuncCode,

                    // Foreign Key to link to primary wire detail
                    FK_WireID = thiswire.WireID
                });

                domesticWireUpdate.BnfInfoes.Add(new BnfInfo
                {
                    // {4000} Intermediary FI
                    InterFI_ID = "F", // B, C, D, F, U (F is Fed ABA) - Placeholder
                    InterFI_Ident = interBankABA.Text,
                    InterFI_Name = interBankName.Text,
                    InterFI_Addr1 = interBankAddrOne.Text,
                    InterFI_Addr2 = interBankAddrTwo.Text,
                    InterFI_Addr3 = interBankAddrThree.Text,

                    // {4100} Beneficiary FI
                    BenFI_ID = "D", // B, C, D, F, U (D is DDA) - Placeholder
                    BenFI_Ident = bnfBankABA.Text,
                    BenFI_Name = bnfBankName.Text,
                    BenFI_Addr1 = bnfBankAddrOne.Text,
                    BenFI_Addr2 = bnfBankAddrTwo.Text,
                    BenFI_Addr3 = bnfBankAddrThree.Text,

                    // {4200} Beneficiary
                    Bnf_ID = "D", // B, C, D, F, U, 1, 2, 3, 4, 5, 9  (D is Checking Acct)
                    Bnf_Ident = bnfCustAcctNum.Text,
                    Bnf_Name = bnfCustName.Text,
                    Bnf_Addr1 = bnfCustAddrOne.Text,
                    Bnf_Addr2 = bnfCustAddrTwo.Text,
                    Bnf_Addr3 = bnfCustAddrThree.Text,

                    // Foreign Key to link to primary wire detail
                    FK_WireID = thiswire.WireID
                });

                domesticWireUpdate.OriginatorInfoes.Add(new OriginatorInfo
                {
                    // {5000} Originator
                    Orig_ID = "D", // B, C, D, F, U, 1, 2, 3, 4, 5, 9  (D is Checking Acct)
                    Orig_Ident = dbtCustAcctNum.Text,
                    Orig_Name = dbtCustName.Text,
                    Orig_Addr1 = dbtCustAddrOne.Text,
                    Orig_Addr2 = dbtCustAddrTwo.Text,
                    Orig_Addr3 = dbtCustAddrThree.Text,
                    
                    // {6000} Originator to Beneficiary Information
                    OBI_L1 = obiTextOne.Text,
                    OBI_L2 = obiTextTwo.Text,
                    OBI_L3 = obiTextThree.Text,
                    OBI_L4 = obiTextFour.Text,

                    // Foreign Key to link to primary wire detail
                    FK_WireID = thiswire.WireID
                });

                domesticWireUpdate.SaveChanges();
            }
        }

        private void wireFormSubmit_Click(object sender, EventArgs e)
        {
            updateDomesticWireDetail();
            MessageBox.Show("You have updated the current wire!"); // Placeholder
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

        private void removeWireDetailForEdit()
        {
            using (FWFCdbEntities domesticWireRemove = new FWFCdbEntities())
            {
                var thiswire = domesticWireRemove.WireMains.Where(w => w.WireID == domWireIDNum).FirstOrDefault();
                thiswire.Status = "UNVR";
                thiswire.Modified_DateTime = DateTime.Now;
                thiswire.Modified_UserName = username;

                domesticWireRemove.BnfInfoes.RemoveRange(thiswire.BnfInfoes.Where(w => w.FK_WireID == domWireIDNum));
                domesticWireRemove.MandatoryFields.RemoveRange(thiswire.MandatoryFields.Where(w => w.FK_WireID == domWireIDNum));
                domesticWireRemove.OriginatorInfoes.RemoveRange(thiswire.OriginatorInfoes.Where(w => w.FK_WireID == domWireIDNum));

                domesticWireRemove.SaveChanges();
            }
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
                removeWireDetailForEdit();
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

        private void wireAmt_Leave(object sender, EventArgs e)
        {
            if (wireAmt.Text != "")
            {
                wireAmt.Text = string.Format("{0:C2}", decimal.Parse(wireAmt.Text, System.Globalization.NumberStyles.Currency));
            }
        }
    }
}
