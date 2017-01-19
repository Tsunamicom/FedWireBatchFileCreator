namespace FedWire_Batch_File_Creator
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StructRemitOnce")]
    public partial class StructRemitOnce
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StructRemitOnce_ID { get; set; }

        [StringLength(2)]
        public string RemitOrig_Type { get; set; }

        [StringLength(4)]
        public string RemitOrig_Code { get; set; }

        [StringLength(140)]
        public string RemitOrig_Name { get; set; }

        [StringLength(35)]
        public string RemitOrig_IDNum { get; set; }

        [StringLength(35)]
        public string RemitOrig_IDNumIss { get; set; }

        [StringLength(82)]
        public string RemitOrig_Birth { get; set; }

        [StringLength(4)]
        public string RemitOrig_AddrType { get; set; }

        [StringLength(70)]
        public string RemitOrig_Dept { get; set; }

        [StringLength(70)]
        public string RemitOrig_SubDept { get; set; }

        [StringLength(70)]
        public string RemitOrig_StreetName { get; set; }

        [StringLength(16)]
        public string RemitOrig_BldgNum { get; set; }

        [StringLength(16)]
        public string RemitOrig_PostCode { get; set; }

        [StringLength(35)]
        public string RemitOrig_TownName { get; set; }

        [StringLength(35)]
        public string RemitOrig_CountrySub { get; set; }

        [StringLength(2)]
        public string RemitOrig_Country { get; set; }

        [StringLength(70)]
        public string RemitOrig_Addr1 { get; set; }

        [StringLength(70)]
        public string RemitOrig_Addr2 { get; set; }

        [StringLength(70)]
        public string RemitOrig_Addr3 { get; set; }

        [StringLength(70)]
        public string RemitOrig_Addr4 { get; set; }

        [StringLength(70)]
        public string RemitOrig_Addr5 { get; set; }

        [StringLength(70)]
        public string RemitOrig_Addr6 { get; set; }

        [StringLength(70)]
        public string RemitOrig_Addr7 { get; set; }

        [StringLength(2)]
        public string RemitOrig_CountryRes { get; set; }

        [StringLength(140)]
        public string RemitOrig_ContactName { get; set; }

        [StringLength(35)]
        public string RemitOrig_PhoneNum { get; set; }

        [StringLength(35)]
        public string RemitOrig_MobileNum { get; set; }

        [StringLength(35)]
        public string RemitOrig_FaxNum { get; set; }

        [StringLength(2048)]
        public string RemitOrig_ContactElec { get; set; }

        [StringLength(35)]
        public string RemitOrig_ContactOther { get; set; }

        [StringLength(140)]
        public string RemitBnf_Name { get; set; }

        [StringLength(2)]
        public string RemitBnf_ { get; set; }

        [StringLength(4)]
        public string RemitBnf_Code { get; set; }

        [StringLength(35)]
        public string RemitBnf_IDNum { get; set; }

        [StringLength(35)]
        public string RemitBnf_IDNumIss { get; set; }

        [StringLength(82)]
        public string RemitBnf_Birth { get; set; }

        [StringLength(4)]
        public string RemitBnf_AddrType { get; set; }

        [StringLength(70)]
        public string RemitBnf_Dept { get; set; }

        [StringLength(70)]
        public string RemitBnf_SubDept { get; set; }

        [StringLength(70)]
        public string RemitBnf_StreetName { get; set; }

        [StringLength(16)]
        public string RemitBnf_BldgNum { get; set; }

        [StringLength(16)]
        public string RemitBnf_PostCode { get; set; }

        [StringLength(35)]
        public string RemitBnf_TownName { get; set; }

        [StringLength(35)]
        public string RemitBnf_CountrySub { get; set; }

        [StringLength(2)]
        public string RemitBnf_Country { get; set; }

        [StringLength(70)]
        public string RemitBnf_Addr1 { get; set; }

        [StringLength(70)]
        public string RemitBnf_Addr2 { get; set; }

        [StringLength(70)]
        public string RemitBnf_Addr3 { get; set; }

        [StringLength(70)]
        public string RemitBnf_Addr4 { get; set; }

        [StringLength(70)]
        public string RemitBnf_Addr5 { get; set; }

        [StringLength(70)]
        public string RemitBnf_Addr6 { get; set; }

        [StringLength(70)]
        public string RemitBnf_Addr7 { get; set; }

        [StringLength(2)]
        public string RemitBnf_CountryRes { get; set; }

        public int FK_WireID { get; set; }

        public virtual WireMain WireMain { get; set; }
    }
}
