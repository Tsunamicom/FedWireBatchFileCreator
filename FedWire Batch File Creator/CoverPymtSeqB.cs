namespace FedWire_Batch_File_Creator
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CoverPymtSeqB")]
    public partial class CoverPymtSeqB
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CoverPymt_ID { get; set; }

        [StringLength(5)]
        public string B33B_SWIFT { get; set; }

        [StringLength(18)]
        public string B33B_Amt { get; set; }

        [StringLength(5)]
        public string B50A_SWIFT { get; set; }

        [StringLength(35)]
        public string B50A_L1 { get; set; }

        [StringLength(35)]
        public string B50A_L2 { get; set; }

        [StringLength(35)]
        public string B50A_L3 { get; set; }

        [StringLength(35)]
        public string B50A_L4 { get; set; }

        [StringLength(35)]
        public string B50A_L5 { get; set; }

        [StringLength(5)]
        public string B52A_SWIFT { get; set; }

        [StringLength(35)]
        public string B52A_L1 { get; set; }

        [StringLength(35)]
        public string B52A_L2 { get; set; }

        [StringLength(35)]
        public string B52A_L3 { get; set; }

        [StringLength(35)]
        public string B52A_L4 { get; set; }

        [StringLength(35)]
        public string B52A_L5 { get; set; }

        [StringLength(5)]
        public string B56A_SWIFT { get; set; }

        [StringLength(35)]
        public string B56A_L1 { get; set; }

        [StringLength(35)]
        public string B56A_L2 { get; set; }

        [StringLength(35)]
        public string B56A_L3 { get; set; }

        [StringLength(35)]
        public string B56A_L4 { get; set; }

        [StringLength(35)]
        public string B56A_L5 { get; set; }

        [StringLength(5)]
        public string B57A_SWIFT { get; set; }

        [StringLength(35)]
        public string B57A_L1 { get; set; }

        [StringLength(35)]
        public string B57A_L2 { get; set; }

        [StringLength(35)]
        public string B57A_L3 { get; set; }

        [StringLength(35)]
        public string B57A_L4 { get; set; }

        [StringLength(35)]
        public string B57A_L5 { get; set; }

        [StringLength(5)]
        public string B59A_SWIFT { get; set; }

        [StringLength(35)]
        public string B59A_L1 { get; set; }

        [StringLength(35)]
        public string B59A_L2 { get; set; }

        [StringLength(35)]
        public string B59A_L3 { get; set; }

        [StringLength(35)]
        public string B59A_L4 { get; set; }

        [StringLength(35)]
        public string B59A_L5 { get; set; }

        [StringLength(5)]
        public string B70_SWIFT { get; set; }

        [StringLength(35)]
        public string B70_L1 { get; set; }

        [StringLength(35)]
        public string B70_L2 { get; set; }

        [StringLength(35)]
        public string B70_L3 { get; set; }

        [StringLength(35)]
        public string B70_L4 { get; set; }

        [StringLength(5)]
        public string B72_SWIFT { get; set; }

        [StringLength(35)]
        public string B72_L1 { get; set; }

        [StringLength(35)]
        public string B72_L2 { get; set; }

        [StringLength(35)]
        public string B72_L3 { get; set; }

        [StringLength(35)]
        public string B72_L4 { get; set; }

        [StringLength(35)]
        public string B72_L5 { get; set; }

        [StringLength(35)]
        public string B72_L6 { get; set; }

        public int FK_WireID { get; set; }

        public virtual WireMain WireMain { get; set; }
    }
}
