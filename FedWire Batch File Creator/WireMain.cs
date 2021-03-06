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
    
    public partial class WireMain
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WireMain()
        {
            this.BnfInfoes = new HashSet<BnfInfo>();
            this.CoverPymtSeqBs = new HashSet<CoverPymtSeqB>();
            this.FedWireSVCInfoes = new HashSet<FedWireSVCInfo>();
            this.FItoFI_Info = new HashSet<FItoFI_Info>();
            this.MandatoryFields = new HashSet<MandatoryField>();
            this.OriginatorInfoes = new HashSet<OriginatorInfo>();
            this.OtherTransferInfoes = new HashSet<OtherTransferInfo>();
            this.RelatedRemitInfoes = new HashSet<RelatedRemitInfo>();
            this.StructRemitOnces = new HashSet<StructRemitOnce>();
            this.StructRemitRepeats = new HashSet<StructRemitRepeat>();
            this.SVCInfoes = new HashSet<SVCInfo>();
            this.UnstructAddendas = new HashSet<UnstructAddenda>();
        }
    
        public int WireID { get; set; }
        public Nullable<System.DateTime> Init_DateTime { get; set; }
        public string Init_UserName { get; set; }
        public Nullable<System.DateTime> Modified_DateTime { get; set; }
        public string Modified_UserName { get; set; }
        public Nullable<System.DateTime> Verify_DateTime { get; set; }
        public string Verify_UserName { get; set; }
        public string Status { get; set; }
        public Nullable<int> FK_BatchID { get; set; }
    
        public virtual Batch Batch { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BnfInfo> BnfInfoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoverPymtSeqB> CoverPymtSeqBs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FedWireSVCInfo> FedWireSVCInfoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FItoFI_Info> FItoFI_Info { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MandatoryField> MandatoryFields { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OriginatorInfo> OriginatorInfoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OtherTransferInfo> OtherTransferInfoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RelatedRemitInfo> RelatedRemitInfoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StructRemitOnce> StructRemitOnces { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StructRemitRepeat> StructRemitRepeats { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SVCInfo> SVCInfoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UnstructAddenda> UnstructAddendas { get; set; }
    }
}
