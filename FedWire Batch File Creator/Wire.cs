using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FedWire_Batch_File_Creator
{
    public class Wire
    {
        // Wire ID (Assigned by Database)
        public int wireID { get; set; }

        // Intitiating Individual (Assigned by Login Profile)
        public string initiatorName { get; set; }
        public DateTime initiatedTime { get; set; }

        // Approval Individual (Assigned by Login Profile) - Dual Control
        public string approverName { get; set; }
        public DateTime approvedTime { get; set; }

        // Can only approve once Initiator is done with input
        public bool readyToApprove = false;

        //************************************************************************
        //                         WIRE FIELDS
        // 
        // {1500} Sender Supplied Information
        public FedWireField SenderSuppliedInfo = new FedWireField("1500", isMandatory: true);

        // {1510} Type/Subtype
        public FedWireField WireType = new FedWireField(tag: "1510", isMandatory: true);

        // {1520} Input Message Accountability Data (IMAD)
        public FedWireField IMAD = new FedWireField(tag: "1520", isMandatory: true);

        // {2000} Amount
        public FedWireField WireAmount = new FedWireField(tag: "2000", isMandatory: true);

        // {3100} Sender DI
        public FedWireField SenderDI = new FedWireField(tag: "3100", isMandatory: true);

        // {3400} Reciever DI
        public FedWireField RecieverDI = new FedWireField(tag: "3400", isMandatory: true);

        // {3600} Business Function Code
        public FedWireField BusinessFunctionCode = new FedWireField(tag: "3600", isMandatory: true);

        // {3320} Sender Reference
        public FedWireField SenderReference = new FedWireField(tag: "3320");

        // {3500} Previous Message Identifier
        public FedWireField PreviousMessageIdentifier = new FedWireField(tag: "3500");

        // {3610} Local Instrument
        public FedWireField LocalInstrument = new FedWireField(tag: "3610");

        // {3620} Payment Notification
        public FedWireField PaymentNotification = new FedWireField(tag: "3620");

        // {3700} Charges
        public FedWireField WireCharges = new FedWireField(tag: "3700");

        // {3710} Instructed Amount
        public FedWireField InstructedAmount = new FedWireField(tag: "3710");

        // {3720} Exchange Rate
        public FedWireField ExchangeRate = new FedWireField(tag: "3720");

        // {4000} Intermediary FI
        public FedWireField IntermediaryFI = new FedWireField(tag: "4000");

        // {4100} Beneficiary FI
        public FedWireField BeneficiaryFI = new FedWireField(tag: "4100");

        // {4200} Beneficiary
        public FedWireField Beneficiary = new FedWireField(tag: "4200");

        // {4320} Reference for Beneficiary
        public FedWireField ReferenceForBeneficiary = new FedWireField(tag: "4320");

        // {4400} Account Debited in Drawdown
        public FedWireField AccountDebitedInDrawdown = new FedWireField(tag: "4400");

        // {5000} Originator
        public FedWireField Originator = new FedWireField(tag: "5000");

        // {5010} Originator Option F
        public FedWireField OriginatorOptionF = new FedWireField(tag: "5010");

        // {5100} Originator FI
        public FedWireField OriginatorFI = new FedWireField(tag: "5100");

        // {5200} Instructing FI
        public FedWireField InstructingFI = new FedWireField(tag: "5200");

        // {5400} Account Credited in Drawdown
        public FedWireField AccountCreditedInDrawdown = new FedWireField(tag: "5400");

        // {6000} Originator to Beneficiary Information
        public FedWireField OriginatorToBeneficiaryInfo = new FedWireField(tag: "6000");

        // {6100} Receiver FI Information
        public FedWireField ReceiverFIInfo = new FedWireField(tag: "6100");

        // {6110} Drawdown Debit Account Advice Information
        public FedWireField DrawdownDebitAccountAdviceInfo = new FedWireField(tag: "6110");

        // {6200} Intermediary FI Information
        public FedWireField IntermediaryFIInfo = new FedWireField(tag: "6200");

        // {6210} Intermediary FI Advice Information
        public FedWireField IntermediaryFIAdviceInfo = new FedWireField(tag: "6210");

        // {6300} Beneficiary's FI Information
        public FedWireField BeneficiaryFIInfo = new FedWireField(tag: "6300");

        // {6310} Beneficiary's FI Advice Information
        public FedWireField BeneficiaryFIAdviceInfo = new FedWireField(tag: "6300");

        // {6400} Beneficiary Information
        public FedWireField BeneficiaryInfo = new FedWireField(tag: "6400");

        // {6410} Beneficiary Advice Information
        public FedWireField BeneficiaryAdviceInfo = new FedWireField(tag: "6410");

        // {6420} Method of Payment to Beneficiary
        public FedWireField MethodOfPaymentToBeneficiary = new FedWireField(tag: "6420");

        // {6500} FI to FI Information
        public FedWireField FItoFIInfo = new FedWireField(tag: "6500");

        // {7033} Sequence B 33B Currency/Instructed Amount
        public FedWireField SequenceBCurrencyAmt = new FedWireField(tag: "7033");

        // {7050} Sequence B 50a Ordering Customer
        public FedWireField SequenceBOrderingCustomer = new FedWireField(tag: "7050");

        // {7052} Sequence B 52a Ordering Institution
        public FedWireField SequenceBOrderingInstitution = new FedWireField(tag: "7052");

        // {7056} Sequence B 56a Intermediary Institution
        public FedWireField SequenceBIntermediaryInstitution = new FedWireField(tag: "7056");

        // {7057} Sequence B 57a Account with Institution
        public FedWireField SequenceBAccountWithInstitution = new FedWireField(tag: "7057");

        // {7059} Sequence B 59a Beneficiary Customer
        public FedWireField SequenceBBeneficiaryCustomer = new FedWireField(tag: "7059");

        // {7070} Sequence B 70a Remittance Information
        public FedWireField SequenceBRemittanceInfo = new FedWireField(tag: "7070");

        // {7072} Sequence B 72a Sender to Reciever Information
        public FedWireField SequenceBSenderToRecieverInfo = new FedWireField(tag: "7072");

        // {8200} Unstructured Addenda Information
        public FedWireField UnstructuredAddendaInfo = new FedWireField(tag: "8200");

        // {8250} Related Remittance Information
        public FedWireField RelatedRemittanceInfo = new FedWireField(tag: "8250");

        // {8300} Remittance Originator
        public FedWireField RemittanceOriginator = new FedWireField(tag: "8300");

        // {8350} Remittance Beneficiary
        public FedWireField RemittanceBeneficiary = new FedWireField(tag: "8350");

        // {8400} Primary Remittance Document Information
        public FedWireField PrimaryRemittanceDocInfo = new FedWireField(tag: "8400");

        // {8450} Actual Paid Amount
        public FedWireField ActualPaidAmount = new FedWireField(tag: "8450");

        // {8500} Gross Amount of Remittance Document
        public FedWireField GrossAmountOfRemittanceDoc = new FedWireField(tag: "8500");

        // {8550} Amount of Negotiated Discount
        public FedWireField AmountOfNegotiatedDiscount = new FedWireField(tag: "8550");

        // {8600} Adjustment Information
        public FedWireField AdjustmentInfo = new FedWireField(tag: "8600");

        // {8650} Date of Remittance Document
        public FedWireField DateOfRemittanceDocument = new FedWireField(tag: "8650");

        // {8700} Secondary Remittance Document Information
        public FedWireField SecondaryRemittanceDocumentInfo = new FedWireField(tag: "8700");

        // {8750} Remittance Free Text
        public FedWireField RemittanceFreeText = new FedWireField(tag: "8750");

        // {9000} Service Message Information
        public FedWireField ServiceMessageInfo = new FedWireField(tag: "9000");

        // {1100} Message Disposition
        public FedWireField MessageDisposition = new FedWireField(tag: "1100");

        // {1110} Receipt Time Stamp
        public FedWireField ReceiptTimeStamp = new FedWireField(tag: "1110");

        // {1120} Output Message Accountability Data (OMAD)
        public FedWireField OMAD = new FedWireField(tag: "1120");

        // {1130} Error
        public FedWireField WireError = new FedWireField(tag: "1130");

        //                     END WIRE FIELDS
        //************************************************************************
    }
}
