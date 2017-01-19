namespace FedWire_Batch_File_Creator
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SVCInfo")]
    public partial class SVCInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ServiceInfo_ID { get; set; }

        [StringLength(35)]
        public string SVCInfo_L1 { get; set; }

        [StringLength(35)]
        public string SVCInfo_L2 { get; set; }

        [StringLength(35)]
        public string SVCInfo_L3 { get; set; }

        [StringLength(35)]
        public string SVCInfo_L4 { get; set; }

        [StringLength(35)]
        public string SVCInfo_L5 { get; set; }

        [StringLength(35)]
        public string SVCInfo_L6 { get; set; }

        [StringLength(35)]
        public string SVCInfo_L7 { get; set; }

        [StringLength(35)]
        public string SVCInfo_L8 { get; set; }

        [StringLength(35)]
        public string SVCInfo_L9 { get; set; }

        [StringLength(35)]
        public string SVCInfo_L10 { get; set; }

        [StringLength(35)]
        public string SVCInfo_L11 { get; set; }

        [StringLength(35)]
        public string SVCInfo_L12 { get; set; }

        public int FK_WireID { get; set; }

        public virtual WireMain WireMain { get; set; }
    }
}
