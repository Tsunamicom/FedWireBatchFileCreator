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
    
    public partial class CoverPymtSeqB
    {
        public int CoverPymt_ID { get; set; }
        public string B33B_SWIFT { get; set; }
        public string B33B_Amt { get; set; }
        public string B50A_SWIFT { get; set; }
        public string B50A_L1 { get; set; }
        public string B50A_L2 { get; set; }
        public string B50A_L3 { get; set; }
        public string B50A_L4 { get; set; }
        public string B50A_L5 { get; set; }
        public string B52A_SWIFT { get; set; }
        public string B52A_L1 { get; set; }
        public string B52A_L2 { get; set; }
        public string B52A_L3 { get; set; }
        public string B52A_L4 { get; set; }
        public string B52A_L5 { get; set; }
        public string B56A_SWIFT { get; set; }
        public string B56A_L1 { get; set; }
        public string B56A_L2 { get; set; }
        public string B56A_L3 { get; set; }
        public string B56A_L4 { get; set; }
        public string B56A_L5 { get; set; }
        public string B57A_SWIFT { get; set; }
        public string B57A_L1 { get; set; }
        public string B57A_L2 { get; set; }
        public string B57A_L3 { get; set; }
        public string B57A_L4 { get; set; }
        public string B57A_L5 { get; set; }
        public string B59A_SWIFT { get; set; }
        public string B59A_L1 { get; set; }
        public string B59A_L2 { get; set; }
        public string B59A_L3 { get; set; }
        public string B59A_L4 { get; set; }
        public string B59A_L5 { get; set; }
        public string B70_SWIFT { get; set; }
        public string B70_L1 { get; set; }
        public string B70_L2 { get; set; }
        public string B70_L3 { get; set; }
        public string B70_L4 { get; set; }
        public string B72_SWIFT { get; set; }
        public string B72_L1 { get; set; }
        public string B72_L2 { get; set; }
        public string B72_L3 { get; set; }
        public string B72_L4 { get; set; }
        public string B72_L5 { get; set; }
        public string B72_L6 { get; set; }
        public Nullable<int> FK_WireID { get; set; }
        public Nullable<int> FK_TemplateID { get; set; }
    
        public virtual WireMain WireMain { get; set; }
        public virtual WireTemplate WireTemplate { get; set; }
    }
}
