namespace FedWire_Batch_File_Creator
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OriginatorInfo")]
    public partial class OriginatorInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Originator_ID { get; set; }

        [StringLength(1)]
        public string Orig_ID { get; set; }

        [StringLength(34)]
        public string Orig_Ident { get; set; }

        [StringLength(35)]
        public string Orig_Name { get; set; }

        [StringLength(35)]
        public string Orig_Addr1 { get; set; }

        [StringLength(35)]
        public string Orig_Addr2 { get; set; }

        [StringLength(35)]
        public string Orig_Addr3 { get; set; }

        [StringLength(35)]
        public string Orig_Addr4 { get; set; }

        [StringLength(35)]
        public string OrigOptF_ID { get; set; }

        [StringLength(35)]
        public string OrigOptF_Name { get; set; }

        [StringLength(35)]
        public string OrigOptF_L1 { get; set; }

        [StringLength(35)]
        public string OrigOptF_L2 { get; set; }

        [StringLength(35)]
        public string OrigOptF_L3 { get; set; }

        [StringLength(1)]
        public string OrigFI_ID { get; set; }

        [StringLength(34)]
        public string OrigFI_Ident { get; set; }

        [StringLength(35)]
        public string OrigFI_Name { get; set; }

        [StringLength(35)]
        public string OrigFI_Addr1 { get; set; }

        [StringLength(35)]
        public string OrigFI_Addr2 { get; set; }

        [StringLength(35)]
        public string OrigFI_Addr3 { get; set; }

        [StringLength(1)]
        public string InstructFI_ID { get; set; }

        [StringLength(34)]
        public string InstructFI_Ident { get; set; }

        [StringLength(34)]
        public string InstructFI_Name { get; set; }

        [StringLength(35)]
        public string InstructFI_Addr1 { get; set; }

        [StringLength(35)]
        public string InstructFI_Addr2 { get; set; }

        [StringLength(35)]
        public string InstructFI_Addr3 { get; set; }

        [StringLength(9)]
        public string AcctCredDrawDown { get; set; }

        [StringLength(35)]
        public string OBI_L1 { get; set; }

        [StringLength(35)]
        public string OBI_L2 { get; set; }

        [StringLength(35)]
        public string OBI_L3 { get; set; }

        [StringLength(35)]
        public string OBI_L4 { get; set; }

        public int FK_WireID { get; set; }

        public virtual WireMain WireMain { get; set; }
    }
}
