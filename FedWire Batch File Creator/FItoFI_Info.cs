namespace FedWire_Batch_File_Creator
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FItoFI_Info
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(30)]
        public string FIFI_RecInfo1 { get; set; }

        [StringLength(33)]
        public string FIFI_RecInfo2 { get; set; }

        [StringLength(33)]
        public string FIFI_RecInfo3 { get; set; }

        [StringLength(33)]
        public string FIFI_RecInfo4 { get; set; }

        [StringLength(33)]
        public string FIFI_RecInfo5 { get; set; }

        [StringLength(33)]
        public string FIFI_RecInfo6 { get; set; }

        [StringLength(3)]
        public string DrawDbtAdv_Code { get; set; }

        [StringLength(26)]
        public string DrawDbtAdv_Info1 { get; set; }

        [StringLength(33)]
        public string DrawDbtAdv_Info2 { get; set; }

        [StringLength(33)]
        public string DrawDbtAdv_Info3 { get; set; }

        [StringLength(33)]
        public string DrawDbtAdv_Info4 { get; set; }

        [StringLength(33)]
        public string DrawDbtAdv_Info5 { get; set; }

        [StringLength(33)]
        public string DrawDbtAdv_Info6 { get; set; }

        [StringLength(30)]
        public string InterFI_Info1 { get; set; }

        [StringLength(33)]
        public string InterFI_Info2 { get; set; }

        [StringLength(33)]
        public string InterFI_Info3 { get; set; }

        [StringLength(33)]
        public string InterFI_Info4 { get; set; }

        [StringLength(33)]
        public string InterFI_Info5 { get; set; }

        [StringLength(33)]
        public string InterFI_Info6 { get; set; }

        [StringLength(3)]
        public string InterFIAdv_Code { get; set; }

        [StringLength(26)]
        public string InterFIAdv_Info1 { get; set; }

        [StringLength(33)]
        public string InterFIAdv_Info2 { get; set; }

        [StringLength(33)]
        public string InterFIAdv_Info3 { get; set; }

        [StringLength(33)]
        public string InterFIAdv_Info4 { get; set; }

        [StringLength(33)]
        public string InterFIAdv_Info5 { get; set; }

        [StringLength(33)]
        public string InterFIAdv_Info6 { get; set; }

        [StringLength(30)]
        public string BnfFI_Info1 { get; set; }

        [StringLength(33)]
        public string BnfFI_Info2 { get; set; }

        [StringLength(33)]
        public string BnfFI_Info3 { get; set; }

        [StringLength(33)]
        public string BnfFI_Info4 { get; set; }

        [StringLength(33)]
        public string BnfFI_Info5 { get; set; }

        [StringLength(33)]
        public string BnfFI_Info6 { get; set; }

        [StringLength(3)]
        public string BnfFIAdv_Code { get; set; }

        [StringLength(26)]
        public string BnfFIAdv_Info1 { get; set; }

        [StringLength(33)]
        public string BnfFIAdv_Info2 { get; set; }

        [StringLength(33)]
        public string BnfFIAdv_Info3 { get; set; }

        [StringLength(33)]
        public string BnfFIAdv_Info4 { get; set; }

        [StringLength(33)]
        public string BnfFIAdv_Info5 { get; set; }

        [StringLength(33)]
        public string BnfFIAdv_Info6 { get; set; }

        [StringLength(5)]
        public string MethodPmtBnf_Method { get; set; }

        [StringLength(30)]
        public string MethodPmtBnf_Info { get; set; }

        [StringLength(35)]
        public string FI_to_FI_Info1 { get; set; }

        [StringLength(35)]
        public string FI_to_FI_Info2 { get; set; }

        [StringLength(35)]
        public string FI_to_FI_Info3 { get; set; }

        [StringLength(35)]
        public string FI_to_FI_Info4 { get; set; }

        [StringLength(35)]
        public string FI_to_FI_Info5 { get; set; }

        [StringLength(35)]
        public string FI_to_FI_Info6 { get; set; }

        public int FK_WireID { get; set; }

        public virtual WireMain WireMain { get; set; }
    }
}
