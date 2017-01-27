using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FedWire_Batch_File_Creator
{
    class Wire: IWireFields
    {
        // **** MANDATORY TAGS FOR ALL TRANSFERS ****
        // {1500} Sender Supplied Information
        public string SSI_Format { get; set; }
        public string SSI_URC { get; set; }
        public string SSI_TPC { get; set; }
        public string SSI_MDC { get; set; }

        // {1510} Type/SubType
        public string TypeCode { get; set; }
        public string SubType { get; set; }

        // {1520} Input Message Accountability Data (IMAD)
        public string IMAD_ICD { get; set; }
        public string IMAD_Source { get; set; }
        public string IMAD_Seq { get; set; }

        // {2000} Amount
        public string WireAmount { get; set; }

        // {3100} Sender DI
        public string SenderDI_ABA { get; set; }
        public string SenderDI_ShortName { get; set; }

        // {3400} Receiver DI
        public string RecieverDI_ABA { get; set; }
        public string ReceiverDI_ShortName { get; set; }

        // {3600} Business Function Code
        public string BusinessFunctionCode { get; set; }
        public string TransactionTypeCode { get; set; }


        // **** OTHER TRANSFER INFORMATION ****
        // {3320} Sender Reference
        public string SenderRef { get; set; }

        // {3500} Previous Message Identifier
        public string PrevMsgID { get; set; }

        // {3610} Local Instrument
        public string Local_Code { get; set; }
        public string LocalPropCode { get; set; }

        // {3620} Payment Notification
        public string Pymt_Notification_ID { get; set; }
        public string Pymt_Electronic_Addr { get; set; }
        public string Pymt_ContactName { get; set; }
        public string Pymt_ContactPhoneNum { get; set; }
        public string Pymt_ContactMobile { get; set; }
        public string Pymt_ContactFaxNum { get; set; }
        public string Pymt_EndNotification { get; set; }

        // {3700} Charges
        public string Charges_Details { get; set; }
        public string Charges_SendersF1 { get; set; }
        public string Charges_SendersF2 { get; set; }
        public string Charges_SendersF3 { get; set; }
        public string Charges_SendersF4 { get; set; }

        // {3710} Instructed Amount
        public string InstructedAmtCode { get; set; }
        public string InstructedAmt_Amt { get; set; }

        // {3720} Exchange Rate
        public string ExchangeRate { get; set; }

        // **** BENEFICIARY INFORMATION ****
        // {4000} Intermediary FI
        public string InterFI_ID { get; set; }
        public string InterFI_Ident { get; set; }
        public string InterFI_Name { get; set; }
        public string InterFI_Addr1 { get; set; }
        public string InterFI_Addr2 { get; set; }
        public string InterFI_Addr3 { get; set; }

        // {4100} Beneficiary FI
        public string BenFI_ID { get; set; }
        public string BenFI_Ident { get; set; }
        public string BenFI_Name { get; set; }
        public string BenFI_Addr1 { get; set; }
        public string BenFI_Addr2 { get; set; }
        public string BenFI_Addr3 { get; set; }

        // {4200} Beneficiary
        public string Bnf_ID { get; set; }
        public string Bnf_Ident { get; set; }
        public string Bnf_Name { get; set; }
        public string Bnf_Addr1 { get; set; }
        public string Bnf_Addr2 { get; set; }
        public string Bnf_Addr3 { get; set; }

        // {4320} Reference for Beneficiary
        public string BnfRef { get; set; }

        // {4400} Account Debited in Drawdown
        public string AcctDbtDraw_ID { get; set; }
        public string AcctDbtDraw_Ident { get; set; }
        public string AcctDbtDraw_Name { get; set; }
        public string AcctDbtDraw_Addr1 { get; set; }
        public string AcctDbtDraw_Addr2 { get; set; }
        public string AcctDbtDraw_Addr3 { get; set; }

        // **** ORIGINATOR INFORMATION ****
        // {5000} Originator
        public string Orig_ID { get; set; }
        public string Orig_Ident { get; set; }
        public string Orig_Name { get; set; }
        public string Orig_Addr1 { get; set; }
        public string Orig_Addr2 { get; set; }
        public string Orig_Addr3 { get; set; }

        // {5010} Originator Option F
        public string OrigOptF_ID { get; set; }
        public string OrigOptF_Name { get; set; }
        public string OrigOptF_L1 { get; set; }
        public string OrigOptF_L2 { get; set; }
        public string OrigOptF_L3 { get; set; }

        // {5100} Originator FI
        public string OrigFI_ID { get; set; }
        public string OrigFI_Ident { get; set; }
        public string OrigFI_Name { get; set; }
        public string OrigFI_Addr1 { get; set; }
        public string OrigFI_Addr2 { get; set; }
        public string OrigFI_Addr3 { get; set; }

        // {5200} Instructing FI
        public string InstructFI_ID { get; set; }
        public string InstructFI_Ident { get; set; }
        public string InstructFI_Name { get; set; }
        public string InstructFI_Addr1 { get; set; }
        public string InstructFI_Addr2 { get; set; }
        public string InstructFI_Addr3 { get; set; }

        // {5400} Account Credited in Drawdown
        public string AcctCredDrawDown { get; set; }

        // {6000} Originator to Beneficiary Information 
        public string OBI_L1 { get; set; }
        public string OBI_L2 { get; set; }
        public string OBI_L3 { get; set; }
        public string OBI_L4 { get; set; }

        // **** FINANCIAL INSTITUTION TO FINANCIAL INSTITUTION INFORMATION ****
        // {6100} Receiver FI Information
        public string FIFI_RecInfo1 { get; set; }
        public string FIFI_RecInfo2 { get; set; }
        public string FIFI_RecInfo3 { get; set; }
        public string FIFI_RecInfo4 { get; set; }
        public string FIFI_RecInfo5 { get; set; }
        public string FIFI_RecInfo6 { get; set; }

        // {6110} Drawdown Debit Advice Information
        public string DrawDbtAdv_Code { get; set; }
        public string DrawDbtAdv_Info1 { get; set; }
        public string DrawDbtAdv_Info2 { get; set; }
        public string DrawDbtAdv_Info3 { get; set; }
        public string DrawDbtAdv_Info4 { get; set; }
        public string DrawDbtAdv_Info5 { get; set; }
        public string DrawDbtAdv_Info6 { get; set; }

        // {6200} Intermediary FI Information
        public string InterFI_Info1 { get; set; }
        public string InterFI_Info2 { get; set; }
        public string InterFI_Info3 { get; set; }
        public string InterFI_Info4 { get; set; }
        public string InterFI_Info5 { get; set; }
        public string InterFI_Info6 { get; set; }

        // {6210} Intermediary FI Advice Information
        public string InterFIAdv_Info1 { get; set; }
        public string InterFIAdv_Info2 { get; set; }
        public string InterFIAdv_Info3 { get; set; }
        public string InterFIAdv_Info4 { get; set; }
        public string InterFIAdv_Info5 { get; set; }
        public string InterFIAdv_Info6 { get; set; }

        // {6300} Beneficiary's FI Information
        public string BnfFI_Info1 { get; set; }
        public string BnfFI_Info2 { get; set; }
        public string BnfFI_Info3 { get; set; }
        public string BnfFI_Info4 { get; set; }
        public string BnfFI_Info5 { get; set; }
        public string BnfFI_Info6 { get; set; }

        // {6310} Beneficiary's FI Advice Information
        public string BnfFIAdv_Code { get; set; }
        public string BnfFIAdv_Info1 { get; set; }
        public string BnfFIAdv_Info2 { get; set; }
        public string BnfFIAdv_Info3 { get; set; }
        public string BnfFIAdv_Info4 { get; set; }
        public string BnfFIAdv_Info5 { get; set; }
        public string BnfFIAdv_Info6 { get; set; }

        // {6400} Beneficiary Information
        public string Bnf_Info1 { get; set; }
        public string Bnf_Info2 { get; set; }
        public string Bnf_Info3 { get; set; }
        public string Bnf_Info4 { get; set; }
        public string Bnf_Info5 { get; set; }
        public string Bnf_Info6 { get; set; }

        // {6410} Beneficiary Advice Information
        public string BnfAdv_Code { get; set; }
        public string BnfAdv_Info1 { get; set; }
        public string BnfAdv_Info2 { get; set; }
        public string BnfAdv_Info3 { get; set; }
        public string BnfAdv_Info4 { get; set; }
        public string BnfAdv_Info5 { get; set; }
        public string BnfAdv_Info6 { get; set; }

        // {6420} Method of Payment to Beneficiary
        public string MethodPmtBnf_Method { get; set; }
        public string MethodPmtBnf_Info { get; set; }

        // {6500} FI to FI Information
        public string FI_to_FI_Info1 { get; set; }
        public string FI_to_FI_Info2 { get; set; }
        public string FI_to_FI_Info3 { get; set; }
        public string FI_to_FI_Info4 { get; set; }
        public string FI_to_FI_Info5 { get; set; }
        public string FI_to_FI_Info6 { get; set; }


        // **** COVER PAYMENT INFORMATION ****
        // {7033} Sequence B 33B Currency/Instructed Amount
        public string B33B_SWIFT { get; set; }
        public string B33B_Amt { get; set; }

        // {7050} Sequence B 50a Ordering Customer
        public string B50A_SWIFT { get; set; }
        public string B50A_L1 { get; set; }
        public string B50A_L2 { get; set; }
        public string B50A_L3 { get; set; }
        public string B50A_L4 { get; set; }
        public string B50A_L5 { get; set; }

        // {7052} Sequence B 52a Ordering Institution
        public string B52A_SWIFT { get; set; }
        public string B52A_L1 { get; set; }
        public string B52A_L2 { get; set; }
        public string B52A_L3 { get; set; }
        public string B52A_L4 { get; set; }
        public string B52A_L5 { get; set; }

        // {7056} Sequence B 56a Intermediary Institution
        public string B56A_SWIFT { get; set; }
        public string B56A_L1 { get; set; }
        public string B56A_L2 { get; set; }
        public string B56A_L3 { get; set; }
        public string B56A_L4 { get; set; }
        public string B56A_L5 { get; set; }

        // {7057} Sequence B 57a Account with Institution
        public string B57A_SWIFT { get; set; }
        public string B57A_L1 { get; set; }
        public string B57A_L2 { get; set; }
        public string B57A_L3 { get; set; }
        public string B57A_L4 { get; set; }
        public string B57A_L5 { get; set; }

        // {7059} Sequence B 59a Beneficiary Customer
        public string B59A_SWIFT { get; set; }
        public string B59A_L1 { get; set; }
        public string B59A_L2 { get; set; }
        public string B59A_L3 { get; set; }
        public string B59A_L4 { get; set; }
        public string B59A_L5 { get; set; }

        // {7070} Sequence B 70 Remittance Information
        public string B70_SWIFT { get; set; }
        public string B70_L1 { get; set; }
        public string B70_L2 { get; set; }
        public string B70_L3 { get; set; }
        public string B70_L4 { get; set; }

        // {7072} Sequence B 72 Sender to Receiver Information
        public string B72_SWIFT { get; set; }
        public string B72_L1 { get; set; }
        public string B72_L2 { get; set; }
        public string B72_L3 { get; set; }
        public string B72_L4 { get; set; }
        public string B72_L5 { get; set; }
        public string B72_L6 { get; set; }


        // **** UNSTRUCTURED ADDENDA INFORMATION ****
        // {8200} Unstructured Addenda Information
        public string UA_Length { get; set; }
        public string UA_Info1 { get; set; }
        public string UA_Info2 { get; set; }
        public string UA_Info3 { get; set; }
        public string UA_Info4 { get; set; }
        public string UA_Info5 { get; set; }
        public string UA_Info6 { get; set; }
        public string UA_Info7 { get; set; }
        public string UA_Info8 { get; set; }
        public string UA_Info9 { get; set; }


        // **** RELATED REMITTANCE INFORMATION ****
        // {8250} Related Remittance Information
        public string RelRemit_ID { get; set; }
        public string RelRemit_Loc { get; set; }
        public string RelRemit_ElecAddr { get; set; }
        public string RelRemit_Name { get; set; }
        public string RelRemit_AddrType { get; set; }
        public string RelRemit_Dept { get; set; }
        public string RelRemit_SubDept { get; set; }
        public string RelRemit_StrName { get; set; }
        public string RelRemit_BldgNum { get; set; }
        public string RelRemit_PostCode { get; set; }
        public string RelRemit_TownName { get; set; }
        public string RelRemit_CountrySubDiv { get; set; }
        public string RelRemit_Country { get; set; }
        public string RelRemit_Addr1 { get; set; }
        public string RelRemit_Addr2 { get; set; }
        public string RelRemit_Addr3 { get; set; }
        public string RelRemit_Addr4 { get; set; }
        public string RelRemit_Addr5 { get; set; }
        public string RelRemit_Addr6 { get; set; }
        public string RelRemit_Addr7 { get; set; }


        // **** STRUCTURED REMITTANCE INFORMATION (ONCE) ****
        // {8300} Remittance Originator
        public string RemitOrig_Type { get; set; }
        public string RemitOrig_Code { get; set; }
        public string RemitOrig_Name { get; set; }
        public string RemitOrig_IDNum { get; set; }
        public string RemitOrig_IDNumIss { get; set; }
        public string RemitOrig_Birth { get; set; }
        public string RemitOrig_AddrType { get; set; }
        public string RemitOrig_Dept { get; set; }
        public string RemitOrig_SubDept { get; set; }
        public string RemitOrig_StreetName { get; set; }
        public string RemitOrig_BldgNum { get; set; }
        public string RemitOrig_PostCode { get; set; }
        public string RemitOrig_TownName { get; set; }
        public string RemitOrig_CountrySub { get; set; }
        public string RemitOrig_Country { get; set; }
        public string RemitOrig_Addr1 { get; set; }
        public string RemitOrig_Addr2 { get; set; }
        public string RemitOrig_Addr3 { get; set; }
        public string RemitOrig_Addr4 { get; set; }
        public string RemitOrig_Addr5 { get; set; }
        public string RemitOrig_Addr6 { get; set; }
        public string RemitOrig_Addr7 { get; set; }
        public string RemitOrig_CountryRes { get; set; }
        public string RemitOrig_ContactName { get; set; }
        public string RemitOrig_PhoneNum { get; set; }
        public string RemitOrig_MobileNum { get; set; }
        public string RemitOrig_FaxNum { get; set; }
        public string RemitOrig_ContactElec { get; set; }
        public string RemitOrig_ContactOther { get; set; }

        // {8350} Remittance Beneficiary
        public string RemitBnf_Name { get; set; }
        public string RemitBnf_Type { get; set; }
        public string RemitBnf_Code { get; set; }
        public string RemitBnf_IDNum { get; set; }
        public string RemitBnf_IDNumIss { get; set; }
        public string RemitBnf_Birth { get; set; }
        public string RemitBnf_AddrType { get; set; }
        public string RemitBnf_Dept { get; set; }
        public string RemitBnf_SubDept { get; set; }
        public string RemitBnf_StreetName { get; set; }
        public string RemitBnf_BldgNum { get; set; }
        public string RemitBnf_PostCode { get; set; }
        public string RemitBnf_TownName { get; set; }
        public string RemitBnf_CountrySub { get; set; }
        public string RemitBnf_Country { get; set; }
        public string RemitBnf_Addr1 { get; set; }
        public string RemitBnf_Addr2 { get; set; }
        public string RemitBnf_Addr3 { get; set; }
        public string RemitBnf_Addr4 { get; set; }
        public string RemitBnf_Addr5 { get; set; }
        public string RemitBnf_Addr6 { get; set; }
        public string RemitBnf_Addr7 { get; set; }
        public string RemitBnf_CountryRes { get; set; }


        // **** STRUCTURED REMITTANCE INFORMATION (REPEAT) ****
        // {8400} Primary Remittance Documentation Information
        public string PrimRemit_DocType { get; set; }
        public string PrimRemit_PropDocType { get; set; }
        public string PrimRemit_DocID { get; set; }
        public string PrimRemit_Issuer { get; set; }

        // {8450} Actual Amount Paid
        public string AmtPaid_CurrCode { get; set; }
        public string AmtPaid_Amount { get; set; }

        // {8500} Gross Amount of Remittance Document
        public string GrossAmtRemit_CurrCode { get; set; }
        public string GrossAmtRemit_Amount { get; set; }

        // {8550} Amount of Negotiated Discount
        public string AmtNegDisc_CurrCode { get; set; }
        public string AmtNegDisc_Amount { get; set; }

        // {8600} Adjustment Information
        public string AdjustInfo_RsnCode { get; set; }
        public string AdjustInfo_Indicator { get; set; }
        public string AdjustInfo_CurrCode { get; set; }
        public string AdjustInfo_Amount { get; set; }

        // {8650} Date of Remittance Document
        public string DateOfRemitDoc { get; set; }

        // {8700} Secondary Remittance Document Information
        public string SecRemit_Type { get; set; }
        public string SecRemit_PropDocType { get; set; }
        public string SecRemit_DocID { get; set; }
        public string SecRemit_Issuer { get; set; }

        // {8750} Remittance Free Text
        public string Remit_FreeText1 { get; set; }
        public string Remit_FreeText2 { get; set; }
        public string Remit_FreeText3 { get; set; }


        // **** SERVICE MESSAGE INFORMATION ****
        // {9000} Service Message Information
        public string SVCInfo_L1 { get; set; }
        public string SVCInfo_L2 { get; set; }
        public string SVCInfo_L3 { get; set; }
        public string SVCInfo_L4 { get; set; }
        public string SVCInfo_L5 { get; set; }
        public string SVCInfo_L6 { get; set; }
        public string SVCInfo_L7 { get; set; }
        public string SVCInfo_L8 { get; set; }
        public string SVCInfo_L9 { get; set; }
        public string SVCInfo_L10 { get; set; }
        public string SVCInfo_L11 { get; set; }
        public string SVCInfo_L12 { get; set; }


        // **** INFORMATION APPENDED BY FEDWIRE FUNDS SERVICE ****
        // {1100} Message Disposition
        public string MsgDisp_Version { get; set; }
        public string MsgDisp_ProdCode { get; set; }
        public string MsgDisp_DupCode { get; set; }
        public string MsgDisp_Status { get; set; }

        // {1110} Reciept Time Stamp
        public string RcptTimeStamp_Date { get; set; }
        public string RcptTimeStamp_Time { get; set; }
        public string Rcpt_AppID { get; set; }

        // {1120} Output Message Accountability Data (OMAD)
        public string OMAD_CycleDate { get; set; }
        public string OMAD_DestID { get; set; }
        public string OMAD_SeqNum { get; set; }
        public string OMAD_Date { get; set; }
        public string OMAD_Time { get; set; }
        public string OMAD_FRBID { get; set; }

        // {1130} Error
        public string Error_Category { get; set; }
        public string Error_Code { get; set; }
        public string Error_Desc { get; set; }


        // Foreign Keys
        public Batch BatchID { get; set; }
        public WireTemplate TemplateID { get; set; }
    }
}

