namespace FedWire_Batch_File_Creator
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OtherTransferInfo")]
    public partial class OtherTransferInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OTI_ID { get; set; }

        [StringLength(16)]
        public string SenderRef { get; set; }

        [StringLength(22)]
        public string PrevMsgID { get; set; }

        [StringLength(4)]
        public string Local_Code { get; set; }

        [StringLength(35)]
        public string Local_PropCode { get; set; }

        [StringLength(1)]
        public string Pymt_Notification_ID { get; set; }

        [StringLength(2048)]
        public string Pymt_Electronic_Addr { get; set; }

        [StringLength(140)]
        public string Pymt_ContactName { get; set; }

        [StringLength(35)]
        public string Pymt_ContactPhoneNum { get; set; }

        [StringLength(35)]
        public string Pymt_ContactMobileNum { get; set; }

        [StringLength(35)]
        public string Pymt_ContactFaxNum { get; set; }

        [StringLength(35)]
        public string Pymt_EndNotification { get; set; }

        [StringLength(1)]
        public string Charges_Details { get; set; }

        [StringLength(15)]
        public string Charges_SendersF1 { get; set; }

        [StringLength(15)]
        public string Charges_SendersF2 { get; set; }

        [StringLength(15)]
        public string Charges_SendersF3 { get; set; }

        [StringLength(15)]
        public string Charges_SendersF4 { get; set; }

        [StringLength(3)]
        public string InstructedAmt_Code { get; set; }

        [StringLength(15)]
        public string InstructedAmt_Amt { get; set; }

        [StringLength(12)]
        public string ExchangeRate { get; set; }

        public int FK_WireID { get; set; }

        public virtual WireMain WireMain { get; set; }
    }
}
