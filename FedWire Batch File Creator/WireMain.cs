namespace FedWire_Batch_File_Creator
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WireMain")]
    public partial class WireMain
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WireMain()
        {
            BnfInfoes = new HashSet<BnfInfo>();
            CoverPymtSeqBs = new HashSet<CoverPymtSeqB>();
            FedWireSVCInfoes = new HashSet<FedWireSVCInfo>();
            FItoFI_Info = new HashSet<FItoFI_Info>();
            MandatoryFields = new HashSet<MandatoryField>();
            OriginatorInfoes = new HashSet<OriginatorInfo>();
            OtherTransferInfoes = new HashSet<OtherTransferInfo>();
            RelatedRemitInfoes = new HashSet<RelatedRemitInfo>();
            StructRemitOnces = new HashSet<StructRemitOnce>();
            StructRemitRepeats = new HashSet<StructRemitRepeat>();
            SVCInfoes = new HashSet<SVCInfo>();
            UnstructAddendas = new HashSet<UnstructAddenda>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WireID { get; set; }

        public DateTime? Init_DateTime { get; set; }

        [StringLength(70)]
        public string Init_UserName { get; set; }

        public DateTime? Modified_DateTime { get; set; }

        [StringLength(70)]
        public string Modified_UserName { get; set; }

        public DateTime? Verify_DateTime { get; set; }

        [StringLength(70)]
        public string Verify_UserName { get; set; }

        [StringLength(4)]
        public string Status { get; set; }

        public bool? isTemplate { get; set; }

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
