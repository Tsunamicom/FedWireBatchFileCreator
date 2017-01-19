namespace FedWire_Batch_File_Creator
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StructRemitRepeat")]
    public partial class StructRemitRepeat
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StructRemitRepeat_ID { get; set; }

        [StringLength(4)]
        public string PrimRemit_DocType { get; set; }

        [StringLength(35)]
        public string PrimRemit_PropDocType { get; set; }

        [StringLength(35)]
        public string PrimRemit_DocID { get; set; }

        [StringLength(35)]
        public string PrimRemit_Issuer { get; set; }

        [StringLength(3)]
        public string AmtPaid_CurrCode { get; set; }

        [StringLength(19)]
        public string AmtPaid_Amount { get; set; }

        [StringLength(3)]
        public string GrossAmtRemit_CurrCode { get; set; }

        [StringLength(19)]
        public string GrossAmtRemit_Amount { get; set; }

        [StringLength(3)]
        public string AmtNegDisc_CurrCode { get; set; }

        [StringLength(19)]
        public string AmtNegDisc_Amount { get; set; }

        [StringLength(2)]
        public string AdjustInfo_RsnCode { get; set; }

        [StringLength(4)]
        public string AdjustInfo_Indicator { get; set; }

        [StringLength(3)]
        public string AdjustInfo_CurrCode { get; set; }

        [StringLength(19)]
        public string AdjustInfo_Amount { get; set; }

        [StringLength(140)]
        public string AdjustInfo_Info { get; set; }

        [StringLength(8)]
        public string DateOfRemitDoc { get; set; }

        [StringLength(4)]
        public string SecRemit_Type { get; set; }

        [StringLength(35)]
        public string SecRemit_PropDocType { get; set; }

        [StringLength(35)]
        public string SecRemit_DocID { get; set; }

        [StringLength(35)]
        public string SecRemit_Issuer { get; set; }

        [StringLength(140)]
        public string Remit_FreeText1 { get; set; }

        [StringLength(140)]
        public string Remit_FreeText2 { get; set; }

        [StringLength(140)]
        public string Remit_FreeText3 { get; set; }

        public int FK_WireID { get; set; }

        public virtual WireMain WireMain { get; set; }
    }
}
