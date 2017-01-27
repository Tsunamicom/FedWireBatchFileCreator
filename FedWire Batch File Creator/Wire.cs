using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FedWire_Batch_File_Creator
{
    class Wire
    {
        // **** MANDATORY TAGS FOR ALL TRANSFERS ****
        // {1500} Sender Supplied Information
        string SSI_Format { get; set; }
        string SSI_URC { get; set; }
        string SSI_TPC { get; set; }
        string SSI_MDC { get; set; }

        // {1510} Type/SubType
        string TypeCode { get; set; }
        string SubType { get; set; }

        // {1520} Input Message Accountability Data (IMAD)
        string IMAD_ICD { get; set; }
        string IMAD_Source { get; set; }
        string IMAD_Seq { get; set; }
        
        // {2000} Amount
        string WireAmount { get; set; }

        // {3100} Sender DI
        string SenderDI_ABA { get; set; }
        string SenderDI_ShortName { get; set; }

        // {3400} Receiver DI
        string RecieverDI_ABA { get; set; }
        string ReceiverDI_ShortName { get; set; }

        // {3600} Business Function Code
        string BusinessFunctionCode { get; set; }
        string TransactionTypeCode { get; set; }


        // **** OTHER TRANSFER INFORMATION ****
        // {3320} Sender Reference
        string SenderRef { get; set; }

        // {3500} Previous Message Identifier
        string PrevMsgID { get; set; }

        // {3610} Local Instrument
        string Local_Code { get; set; }
        string LocalPropCode { get; set; }

        // {3620} Payment Notification
        string Pymt_Notification_ID { get; set; }
        string Pymt_Electronic_Addr { get; set; }
        string Pymt_ContactName { get; set; }
        string Pymt_ContactPhoneNum { get; set; }
        string Pymt_ContactMobile { get; set; }
        string Pymt_ContactFaxNum { get; set; }
        string Pymt_EndNotification { get; set; }

        // {3700} Charges
        string Charges_Details { get; set; }
        string Charges_SendersF1 { get; set; }
        string Charges_SendersF2 { get; set; }
        string Charges_SendersF3 { get; set; }
        string Charges_SendersF4 { get; set; }

        // {3710} Instructed Amount
        string InstructedAmtCode { get; set; }
        string InstructedAmt_Amt { get; set; }

        // {3720} Exchange Rate
        string ExchangeRate { get; set; }

        // **** BENEFICIARY INFORMATION ****
        // {4000} Intermediary FI
        string InterFI_ID { get; set; }
        string InterFI_Ident { get; set; }
        string InterFI_Name { get; set; }
        string InterFI_Addr1 { get; set; }
        string InterFI_Addr2 { get; set; }
        string InterFI_Addr3 { get; set; }

        // {4100} Beneficiary FI
        string BenFI_ID { get; set; }
        string BenFI_Ident { get; set; }
        string BenFI_Name { get; set; }
        string BenFI_Addr1 { get; set; }
        string BenFI_Addr2 { get; set; }
        string BenFI_Addr3 { get; set; }

        // {4200} Beneficiary
        string Bnf_ID { get; set; }
        string Bnf_Ident { get; set; }
        string Bnf_Name { get; set; }
        string Bnf_Addr1 { get; set; }
        string Bnf_Addr2 { get; set; }
        string Bnf_Addr3 { get; set; }

        // {4320} Reference for Beneficiary
        string BnfRef { get; set; }

        // {4400} Account Debited in Drawdown
        string AcctDbtDraw_ID { get; set; }
        string AcctDbtDraw_Ident { get; set; }
        string AcctDbtDraw_Name { get; set; }
        string AcctDbtDraw_Addr1 { get; set; }
        string AcctDbtDraw_Addr2 { get; set; }
        string AcctDbtDraw_Addr3 { get; set; }

        // **** ORIGINATOR INFORMATION ****
        // {5000} Originator
        string Orig_ID { get; set; }
        string Orig_Ident { get; set; }
        string Orig_Name { get; set; }
        string Orig_Addr1 { get; set; }
        string Orig_Addr2 { get; set; }
        string Orig_Addr3 { get; set; }

        // {5010} Originator Option F
        string OrigOptF_ID { get; set; }
        string OrigOptF_Name { get; set; }
        string OrigOptF_L1 { get; set; }
        string OrigOptF_L2 { get; set; }
        string OrigOptF_L3 { get; set; }

        // {5100} Originator FI
        string OrigFI_ID { get; set; }
        string OrigFI_Ident { get; set; }
        string OrigFI_Name { get; set; }
        string OrigFI_Addr1 { get; set; }
        string OrigFI_Addr2 { get; set; }
        string OrigFI_Addr3 { get; set; }

        // {5200} Instructing FI
        string InstructFI_ID { get; set; }
        string InstructFI_Ident { get; set; }
        string InstructFI_Name { get; set; }
        string InstructFI_Addr1 { get; set; }
        string InstructFI_Addr2 { get; set; }
        string InstructFI_Addr3 { get; set; }

        // {5400} Account Credited in Drawdown
        string AcctCredDrawDown { get; set; }

        // {6000} Originator to Beneficiary Information 
        string OBI_L1 { get; set; }
        string OBI_L2 { get; set; }
        string OBI_L3 { get; set; }
        string OBI_L4 { get; set; }

        // **** FINANCIAL INSTITUTION TO FINANCIAL INSTITUTION INFORMATION ****
        // {6100} Receiver FI Information
        string FIFI_RecInfo1 { get; set; }
        string FIFI_RecInfo2 { get; set; }
        string FIFI_RecInfo3 { get; set; }
        string FIFI_RecInfo4 { get; set; }
        string FIFI_RecInfo5 { get; set; }
        string FIFI_RecInfo6 { get; set; }

        // {6110} Drawdown Debit Advice Information
        string DrawDbtAdv_Code { get; set; }
        string DrawDbtAdv_Info1 { get; set; }
        string DrawDbtAdv_Info2 { get; set; }
        string DrawDbtAdv_Info3 { get; set; }
        string DrawDbtAdv_Info4 { get; set; }
        string DrawDbtAdv_Info5 { get; set; }
        string DrawDbtAdv_Info6 { get; set; }

        // {6200} Intermediary FI Information
        string InterFI_Info1 { get; set; }
        string InterFI_Info2 { get; set; }
        string InterFI_Info3 { get; set; }
        string InterFI_Info4 { get; set; }
        string InterFI_Info5 { get; set; }
        string InterFI_Info6 { get; set; }

        // {6210} Intermediary FI Advice Information
        string InterFIAdv_Info1 { get; set; }
        string InterFIAdv_Info2 { get; set; }
        string InterFIAdv_Info3 { get; set; }
        string InterFIAdv_Info4 { get; set; }
        string InterFIAdv_Info5 { get; set; }
        string InterFIAdv_Info6 { get; set; }

        // {6300} Beneficiary's FI Information
        string BnfFI_Info1 { get; set; }
        string BnfFI_Info2 { get; set; }
        string BnfFI_Info3 { get; set; }
        string BnfFI_Info4 { get; set; }
        string BnfFI_Info5 { get; set; }
        string BnfFI_Info6 { get; set; }

        // {6310} Beneficiary's FI Advice Information
        string BnfFIAdv_Code { get; set; }
        string BnfFIAdv_Info1 { get; set; }
        string BnfFIAdv_Info2 { get; set; }
        string BnfFIAdv_Info3 { get; set; }
        string BnfFIAdv_Info4 { get; set; }
        string BnfFIAdv_Info5 { get; set; }
        string BnfFIAdv_Info6 { get; set; }

        // {6400} Beneficiary Information
        string Bnf_Info1 { get; set; }
        string Bnf_Info2 { get; set; }
        string Bnf_Info3 { get; set; }
        string Bnf_Info4 { get; set; }
        string Bnf_Info5 { get; set; }
        string Bnf_Info6 { get; set; }

        // {6410} Beneficiary Advice Information
        string BnfAdv_Code { get; set; }
        string BnfAdv_Info1 { get; set; }
        string BnfAdv_Info2 { get; set; }
        string BnfAdv_Info3 { get; set; }
        string BnfAdv_Info4 { get; set; }
        string BnfAdv_Info5 { get; set; }
        string BnfAdv_Info6 { get; set; }

        // {6420} Method of Payment to Beneficiary
        string MethodPmtBnf_Method { get; set; }
        string MethodPmtBnf_Info { get; set; }

        // {6500} FI to FI Information
        string FI_to_FI_Info1 { get; set; }
        string FI_to_FI_Info2 { get; set; }
        string FI_to_FI_Info3 { get; set; }
        string FI_to_FI_Info4 { get; set; }
        string FI_to_FI_Info5 { get; set; }
        string FI_to_FI_Info6 { get; set; }


        // **** COVER PAYMENT INFORMATION ****
        // {7033} Sequence B 33B Currency/Instructed Amount
        string B33B_SWIFT { get; set; }
        string B33B_Amt { get; set; }

        // {7050} Sequence B 50a Ordering Customer
        string B50A_SWIFT { get; set; }
        string B50A_L1 { get; set; }
        string B50A_L2 { get; set; }
        string B50A_L3 { get; set; }
        string B50A_L4 { get; set; }
        string B50A_L5 { get; set; }

        // {7052} Sequence B 52a Ordering Institution
        string B52A_SWIFT { get; set; }
        string B52A_L1 { get; set; }
        string B52A_L2 { get; set; }
        string B52A_L3 { get; set; }
        string B52A_L4 { get; set; }
        string B52A_L5 { get; set; }

        // {7056} Sequence B 56a Intermediary Institution
        string B56A_SWIFT { get; set; }
        string B56A_L1 { get; set; }
        string B56A_L2 { get; set; }
        string B56A_L3 { get; set; }
        string B56A_L4 { get; set; }
        string B56A_L5 { get; set; }

        // {7057} Sequence B 57a Account with Institution
        string B57A_SWIFT { get; set; }
        string B57A_L1 { get; set; }
        string B57A_L2 { get; set; }
        string B57A_L3 { get; set; }
        string B57A_L4 { get; set; }
        string B57A_L5 { get; set; }

        // {7059} Sequence B 59a Beneficiary Customer
        string B59A_SWIFT { get; set; }
        string B59A_L1 { get; set; }
        string B59A_L2 { get; set; }
        string B59A_L3 { get; set; }
        string B59A_L4 { get; set; }
        string B59A_L5 { get; set; }

        // {7070} Sequence B 70 Remittance Information
        string B70_SWIFT { get; set; }
        string B70_L1 { get; set; }
        string B70_L2 { get; set; }
        string B70_L3 { get; set; }
        string B70_L4 { get; set; }

        // {7072} Sequence B 72 Sender to Receiver Information
        string B72_SWIFT { get; set; }
        string B72_L1 { get; set; }
        string B72_L2 { get; set; }
        string B72_L3 { get; set; }
        string B72_L4 { get; set; }
        string B72_L5 { get; set; }
        string B72_L6 { get; set; }


        // **** UNSTRUCTURED ADDENDA INFORMATION ****
        // {8200} Unstructured Addenda Information
        string UA_Length { get; set; }
        string UA_Info1 { get; set; }
        string UA_Info2 { get; set; }
        string UA_Info3 { get; set; }
        string UA_Info4 { get; set; }
        string UA_Info5 { get; set; }
        string UA_Info6 { get; set; }
        string UA_Info7 { get; set; }
        string UA_Info8 { get; set; }
        string UA_Info9 { get; set; }


        // **** RELATED REMITTANCE INFORMATION ****
        // {8250} Related Remittance Information
        string RelRemit_ID { get; set; }
        string RelRemit_Loc { get; set; }
        string RelRemit_ElecAddr { get; set; }
        string RelRemit_Name { get; set; }
        string RelRemit_AddrType { get; set; }
        string RelRemit_Dept { get; set; }
        string RelRemit_SubDept { get; set; }
        string RelRemit_StrName { get; set; }
        string RelRemit_BldgNum { get; set; }
        string RelRemit_PostCode { get; set; }
        string RelRemit_TownName { get; set; }
        string RelRemit_CountrySubDiv { get; set; }
        string RelRemit_Country { get; set; }
        string RelRemit_Addr1 { get; set; }
        string RelRemit_Addr2 { get; set; }
        string RelRemit_Addr3 { get; set; }
        string RelRemit_Addr4 { get; set; }
        string RelRemit_Addr5 { get; set; }
        string RelRemit_Addr6 { get; set; }
        string RelRemit_Addr7 { get; set; }


        // **** STRUCTURED REMITTANCE INFORMATION (ONCE) ****
        // {8300} Remittance Originator
        string RemitOrig_Type { get; set; }
        string RemitOrig_Code { get; set; }
        string RemitOrig_Name { get; set; }
        string RemitOrig_IDNum { get; set; }
        string RemitOrig_IDNumIss { get; set; }
        string RemitOrig_Birth { get; set; }
        string RemitOrig_AddrType { get; set; }
        string RemitOrig_Dept { get; set; }
        string RemitOrig_SubDept { get; set; }
        string RemitOrig_StreetName { get; set; }
        string RemitOrig_BldgNum { get; set; }
        string RemitOrig_PostCode { get; set; }
        string RemitOrig_TownName { get; set; }
        string RemitOrig_CountrySub { get; set; }
        string RemitOrig_Country { get; set; }
        string RemitOrig_Addr1 { get; set; }
        string RemitOrig_Addr2 { get; set; }
        string RemitOrig_Addr3 { get; set; }
        string RemitOrig_Addr4 { get; set; }
        string RemitOrig_Addr5 { get; set; }
        string RemitOrig_Addr6 { get; set; }
        string RemitOrig_Addr7 { get; set; }
        string RemitOrig_CountryRes { get; set; }
        string RemitOrig_ContactName { get; set; }
        string RemitOrig_PhoneNum { get; set; }
        string RemitOrig_MobileNum { get; set; }
        string RemitOrig_FaxNum { get; set; }
        string RemitOrig_ContactElec { get; set; }
        string RemitOrig_ContactOther { get; set; }

        // {8350} Remittance Beneficiary
        string RemitBnf_Name { get; set; }
        string RemitBnf_Type { get; set; }
        string RemitBnf_Code { get; set; }
        string RemitBnf_IDNum { get; set; }
        string RemitBnf_IDNumIss { get; set; }
        string RemitBnf_Birth { get; set; }
        string RemitBnf_AddrType { get; set; }
        string RemitBnf_Dept { get; set; }
        string RemitBnf_SubDept { get; set; }
        string RemitBnf_StreetName { get; set; }
        string RemitBnf_BldgNum { get; set; }
        string RemitBnf_PostCode { get; set; }
        string RemitBnf_TownName { get; set; }
        string RemitBnf_CountrySub { get; set; }
        string RemitBnf_Country { get; set; }
        string RemitBnf_Addr1 { get; set; }
        string RemitBnf_Addr2 { get; set; }
        string RemitBnf_Addr3 { get; set; }
        string RemitBnf_Addr4 { get; set; }
        string RemitBnf_Addr5 { get; set; }
        string RemitBnf_Addr6 { get; set; }
        string RemitBnf_Addr7 { get; set; }
        string RemitBnf_CountryRes { get; set; }


        // **** STRUCTURED REMITTANCE INFORMATION (REPEAT) ****
        // {8400} Primary Remittance Documentation Information
        string PrimRemit_DocType { get; set; }
        string PrimRemit_PropDocType { get; set; }
        string PrimRemit_DocID { get; set; }
        string PrimRemit_Issuer { get; set; }

        // {8450} Actual Amount Paid
        string AmtPaid_CurrCode { get; set; }
        string AmtPaid_Amount { get; set; }

        // {8500} Gross Amount of Remittance Document
        string GrossAmtRemit_CurrCode { get; set; }
        string GrossAmtRemit_Amount { get; set; }

        // {8550} Amount of Negotiated Discount
        string AmtNegDisc_CurrCode { get; set; }
        string AmtNegDisc_Amount { get; set; }

        // {8600} Adjustment Information
        string AdjustInfo_RsnCode { get; set; }
        string AdjustInfo_Indicator { get; set; }
        string AdjustInfo_CurrCode { get; set; }
        string AdjustInfo_Amount { get; set; }

        // {8650} Date of Remittance Document
        string DateOfRemitDoc { get; set; }

        // {8700} Secondary Remittance Document Information
        string SecRemit_Type { get; set; }
        string SecRemit_PropDocType { get; set; }
        string SecRemit_DocID { get; set; }
        string SecRemit_Issuer { get; set; }

        // {8750} Remittance Free Text
        string Remit_FreeText1 { get; set; }
        string Remit_FreeText2 { get; set; }
        string Remit_FreeText3 { get; set; }


        // **** SERVICE MESSAGE INFORMATION ****
        // {9000} Service Message Information
        string SVCInfo_L1 { get; set; }
        string SVCInfo_L2 { get; set; }
        string SVCInfo_L3 { get; set; }
        string SVCInfo_L4 { get; set; }
        string SVCInfo_L5 { get; set; }
        string SVCInfo_L6 { get; set; }
        string SVCInfo_L7 { get; set; }
        string SVCInfo_L8 { get; set; }
        string SVCInfo_L9 { get; set; }
        string SVCInfo_L10 { get; set; }
        string SVCInfo_L11 { get; set; }
        string SVCInfo_L12 { get; set; }


        // **** INFORMATION APPENDED BY FEDWIRE FUNDS SERVICE ****
        // {1100} Message Disposition
        string MsgDisp_Version { get; set; }
        string MsgDisp_ProdCode { get; set; }
        string MsgDisp_DupCode { get; set; }
        string MsgDisp_Status { get; set; }

        // {1110} Reciept Time Stamp
        string RcptTimeStamp_Date { get; set; }
        string RcptTimeStamp_Time { get; set; }
        string Rcpt_AppID { get; set; }
        
        // {1120} Output Message Accountability Data (OMAD)
        string OMAD_CycleDate { get; set; }
        string OMAD_DestID { get; set; }
        string OMAD_SeqNum { get; set; }
        string OMAD_Date { get; set; }
        string OMAD_Time { get; set; }
        string OMAD_FRBID { get; set; }

        // {1130} Error
        string Error_Category { get; set; }
        string Error_Code { get; set; }
        string Error_Desc { get; set; }


        // Foreign Keys
        Batch BatchID { get; set; }
        WireTemplate TemplateID { get; set; }
    }
}

