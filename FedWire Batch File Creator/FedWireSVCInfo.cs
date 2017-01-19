namespace FedWire_Batch_File_Creator
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FedWireSVCInfo")]
    public partial class FedWireSVCInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FedWireSVCInfo_ID { get; set; }

        [StringLength(2)]
        public string MsgDisposition_Version { get; set; }

        [StringLength(1)]
        public string MsgDisp_ProdCode { get; set; }

        [StringLength(1)]
        public string MsgDisp_DupCode { get; set; }

        [StringLength(1)]
        public string MsgDisp_Status { get; set; }

        [StringLength(4)]
        public string RcptTimeStamp_Date { get; set; }

        [StringLength(4)]
        public string RcptTimeStamp_Time { get; set; }

        [StringLength(4)]
        public string Rcpt_AppID { get; set; }

        [StringLength(8)]
        public string OMAD_CycleDate { get; set; }

        [StringLength(8)]
        public string OMAD_DestID { get; set; }

        [StringLength(6)]
        public string OMAD_SeqNum { get; set; }

        [StringLength(4)]
        public string OMAD_Date { get; set; }

        [StringLength(4)]
        public string OMAD_Time { get; set; }

        [StringLength(4)]
        public string OMAD_FRBID { get; set; }

        [StringLength(1)]
        public string Error_Category { get; set; }

        [StringLength(3)]
        public string Error_Code { get; set; }

        [StringLength(35)]
        public string Error_Desc { get; set; }

        public int FK_WireID { get; set; }

        public virtual WireMain WireMain { get; set; }
    }
}
