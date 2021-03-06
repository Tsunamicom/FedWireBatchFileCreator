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
    
    public partial class BnfInfo
    {
        public int Beneficiary_ID { get; set; }
        public string InterFI_ID { get; set; }
        public string InterFI_Ident { get; set; }
        public string InterFI_Name { get; set; }
        public string InterFI_Addr1 { get; set; }
        public string InterFI_Addr2 { get; set; }
        public string InterFI_Addr3 { get; set; }
        public string BenFI_ID { get; set; }
        public string BenFI_Ident { get; set; }
        public string BenFI_Name { get; set; }
        public string BenFI_Addr1 { get; set; }
        public string BenFI_Addr2 { get; set; }
        public string BenFI_Addr3 { get; set; }
        public string Bnf_ID { get; set; }
        public string Bnf_Ident { get; set; }
        public string Bnf_Name { get; set; }
        public string Bnf_Addr1 { get; set; }
        public string Bnf_Addr2 { get; set; }
        public string Bnf_Addr3 { get; set; }
        public string BnfRef { get; set; }
        public string AcctDbtDraw_ID { get; set; }
        public string AcctDbtDraw_Ident { get; set; }
        public string AcctDbtDraw_Name { get; set; }
        public string AcctDbtDraw_Addr1 { get; set; }
        public string AcctDbtDraw_Addr2 { get; set; }
        public string AcctDbtDraw_Addr3 { get; set; }
        public Nullable<int> FK_WireID { get; set; }
        public Nullable<int> FK_TemplateID { get; set; }
    
        public virtual WireMain WireMain { get; set; }
        public virtual WireTemplate WireTemplate { get; set; }
    }
}
