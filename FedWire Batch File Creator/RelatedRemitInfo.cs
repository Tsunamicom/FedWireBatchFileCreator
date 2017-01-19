namespace FedWire_Batch_File_Creator
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RelatedRemitInfo")]
    public partial class RelatedRemitInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RelRemitInfo_ID { get; set; }

        [StringLength(35)]
        public string RelRemit_ID { get; set; }

        [StringLength(4)]
        public string RelRemit_Loc { get; set; }

        [StringLength(2048)]
        public string RemitLoc_ElecAddr { get; set; }

        [StringLength(140)]
        public string RelRemit_Name { get; set; }

        [StringLength(4)]
        public string RelRemit_AddrType { get; set; }

        [StringLength(70)]
        public string RelRemit_Dept { get; set; }

        [StringLength(70)]
        public string RelRemit_SubDept { get; set; }

        [StringLength(70)]
        public string RelRemit_StrName { get; set; }

        [StringLength(16)]
        public string RelRemit_BldgNum { get; set; }

        [StringLength(16)]
        public string RelRemit_PostCode { get; set; }

        [StringLength(35)]
        public string RelRemit_TownName { get; set; }

        [StringLength(35)]
        public string RelRemit_CountrySubDiv { get; set; }

        [StringLength(2)]
        public string RelRemit_Country { get; set; }

        [StringLength(70)]
        public string RelRemit_Addr1 { get; set; }

        [StringLength(70)]
        public string RelRemit_Addr2 { get; set; }

        [StringLength(70)]
        public string RelRemit_Addr3 { get; set; }

        [StringLength(70)]
        public string RelRemit_Addr4 { get; set; }

        [StringLength(70)]
        public string RelRemit_Addr5 { get; set; }

        [StringLength(70)]
        public string RelRemit_Addr6 { get; set; }

        [StringLength(70)]
        public string RelRemit_Addr7 { get; set; }

        public int FK_WireID { get; set; }

        public virtual WireMain WireMain { get; set; }
    }
}
