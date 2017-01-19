namespace FedWire_Batch_File_Creator
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UnstructAddenda")]
    public partial class UnstructAddenda
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Unstruct_Addenda_ID { get; set; }

        [StringLength(4)]
        public string UA_Length { get; set; }

        [StringLength(1000)]
        public string UA_Info1 { get; set; }

        [StringLength(1000)]
        public string UA_Info2 { get; set; }

        [StringLength(1000)]
        public string UA_Info3 { get; set; }

        [StringLength(1000)]
        public string UA_Info4 { get; set; }

        [StringLength(1000)]
        public string UA_Info5 { get; set; }

        [StringLength(1000)]
        public string UA_Info6 { get; set; }

        [StringLength(1000)]
        public string UA_Info7 { get; set; }

        [StringLength(1000)]
        public string UA_Info8 { get; set; }

        [StringLength(994)]
        public string UA_Info9 { get; set; }

        public int FK_WireID { get; set; }

        public virtual WireMain WireMain { get; set; }
    }
}
