namespace FedWire_Batch_File_Creator
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MandatoryField
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MandatoryID { get; set; }

        [Required]
        [StringLength(2)]
        public string SSI_Format { get; set; }

        [Required]
        [StringLength(8)]
        public string SSI_URC { get; set; }

        [Required]
        [StringLength(1)]
        public string SSI_TPC { get; set; }

        [Required]
        [StringLength(1)]
        public string SSI_MDC { get; set; }

        [Required]
        [StringLength(2)]
        public string TypeCode { get; set; }

        [Required]
        [StringLength(2)]
        public string SubType { get; set; }

        [StringLength(8)]
        public string IMAD_ICD { get; set; }

        [StringLength(8)]
        public string IMAD_Source { get; set; }

        [StringLength(6)]
        public string IMAD_Seq { get; set; }

        [Required]
        [StringLength(12)]
        public string WireAmount { get; set; }

        [Required]
        [StringLength(9)]
        public string SenderDI_ABA { get; set; }

        [StringLength(18)]
        public string SenderDI_ShortName { get; set; }

        [Required]
        [StringLength(9)]
        public string ReceiverDI_ABA { get; set; }

        [StringLength(18)]
        public string ReceiverDI_ShortName { get; set; }

        [Required]
        [StringLength(3)]
        public string BusinessFunctionCode { get; set; }

        [StringLength(3)]
        public string TransactionTypeCode { get; set; }

        public int FK_WireID { get; set; }

        public virtual WireMain WireMain { get; set; }
    }
}
