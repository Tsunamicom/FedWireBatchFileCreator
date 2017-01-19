namespace FedWire_Batch_File_Creator
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BnfInfo")]
    public partial class BnfInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Beneficiary_ID { get; set; }

        [StringLength(1)]
        public string InterFI_ID { get; set; }

        [StringLength(34)]
        public string InterFI_Ident { get; set; }

        [StringLength(35)]
        public string InterFI_Name { get; set; }

        [StringLength(35)]
        public string InterFI_Addr1 { get; set; }

        [StringLength(35)]
        public string InterFI_Addr2 { get; set; }

        [StringLength(35)]
        public string InterFI_Addr3 { get; set; }

        [StringLength(1)]
        public string BenFI_ID { get; set; }

        [StringLength(34)]
        public string BenFI_Ident { get; set; }

        [StringLength(35)]
        public string BenFI_Name { get; set; }

        [StringLength(35)]
        public string BenFI_Addr1 { get; set; }

        [StringLength(35)]
        public string BenFI_Addr2 { get; set; }

        [StringLength(35)]
        public string BenFI_Addr3 { get; set; }

        [StringLength(1)]
        public string Bnf_ID { get; set; }

        [StringLength(34)]
        public string Bnf_Ident { get; set; }

        [StringLength(35)]
        public string Bnf_Name { get; set; }

        [StringLength(35)]
        public string Bnf_Addr1 { get; set; }

        [StringLength(35)]
        public string Bnf_Addr2 { get; set; }

        [StringLength(35)]
        public string Bnf_Addr3 { get; set; }

        [StringLength(16)]
        public string BnfRef { get; set; }

        [StringLength(1)]
        public string AcctDbtDraw_ID { get; set; }

        [StringLength(34)]
        public string AcctDbtDraw_Ident { get; set; }

        [StringLength(35)]
        public string AcctDbtDraw_Name { get; set; }

        [StringLength(35)]
        public string AcctDbtDraw_Addr1 { get; set; }

        [StringLength(35)]
        public string AcctDbtDraw_Addr2 { get; set; }

        [StringLength(35)]
        public string AcctDbtDraw_Addr3 { get; set; }

        public int FK_WireID { get; set; }

        public virtual WireMain WireMain { get; set; }
    }
}
