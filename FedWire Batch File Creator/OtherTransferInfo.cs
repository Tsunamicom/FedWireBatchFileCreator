//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FedWire_Batch_File_Creator
{
    using System;
    using System.Collections.Generic;
    
    public partial class OtherTransferInfo
    {
        public int OTI_ID { get; set; }
        public string SenderRef { get; set; }
        public string PrevMsgID { get; set; }
        public string Local_Code { get; set; }
        public string Local_PropCode { get; set; }
        public string Pymt_Notification_ID { get; set; }
        public string Pymt_Electronic_Addr { get; set; }
        public string Pymt_ContactName { get; set; }
        public string Pymt_ContactPhoneNum { get; set; }
        public string Pymt_ContactMobileNum { get; set; }
        public string Pymt_ContactFaxNum { get; set; }
        public string Pymt_EndNotification { get; set; }
        public string Charges_Details { get; set; }
        public string Charges_SendersF1 { get; set; }
        public string Charges_SendersF2 { get; set; }
        public string Charges_SendersF3 { get; set; }
        public string Charges_SendersF4 { get; set; }
        public string InstructedAmt_Code { get; set; }
        public string InstructedAmt_Amt { get; set; }
        public string ExchangeRate { get; set; }
        public Nullable<int> FK_WireID { get; set; }
        public Nullable<int> FK_TemplateID { get; set; }
    
        public virtual WireMain WireMain { get; set; }
        public virtual WireTemplate WireTemplate { get; set; }
    }
}
