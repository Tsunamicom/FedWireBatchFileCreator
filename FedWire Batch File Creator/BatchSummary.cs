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
    
    public partial class BatchSummary
    {
        public int BatchID { get; set; }
        public string Opened_User { get; set; }
        public Nullable<System.DateTime> Opened_Time { get; set; }
        public Nullable<int> Number_of_Wires { get; set; }
        public Nullable<double> Total_Wire_Amt { get; set; }
        public Nullable<bool> OFAC_Verified { get; set; }
    }
}
