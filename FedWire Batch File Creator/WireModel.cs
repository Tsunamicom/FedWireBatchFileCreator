namespace FedWire_Batch_File_Creator
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class WireModel : DbContext
    {
        public WireModel()
            : base("name=WireModel")
        {
        }

        public virtual DbSet<BnfInfo> BnfInfoes { get; set; }
        public virtual DbSet<CoverPymtSeqB> CoverPymtSeqBs { get; set; }
        public virtual DbSet<FedWireSVCInfo> FedWireSVCInfoes { get; set; }
        public virtual DbSet<FItoFI_Info> FItoFI_Info { get; set; }
        public virtual DbSet<MandatoryField> MandatoryFields { get; set; }
        public virtual DbSet<OriginatorInfo> OriginatorInfoes { get; set; }
        public virtual DbSet<OtherTransferInfo> OtherTransferInfoes { get; set; }
        public virtual DbSet<RelatedRemitInfo> RelatedRemitInfoes { get; set; }
        public virtual DbSet<StructRemitOnce> StructRemitOnces { get; set; }
        public virtual DbSet<StructRemitRepeat> StructRemitRepeats { get; set; }
        public virtual DbSet<SVCInfo> SVCInfoes { get; set; }
        public virtual DbSet<UnstructAddenda> UnstructAddendas { get; set; }
        public virtual DbSet<WireMain> WireMains { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BnfInfo>()
                .Property(e => e.InterFI_ID)
                .IsFixedLength();

            modelBuilder.Entity<BnfInfo>()
                .Property(e => e.BenFI_ID)
                .IsFixedLength();

            modelBuilder.Entity<CoverPymtSeqB>()
                .Property(e => e.B33B_SWIFT)
                .IsFixedLength();

            modelBuilder.Entity<CoverPymtSeqB>()
                .Property(e => e.B50A_SWIFT)
                .IsFixedLength();

            modelBuilder.Entity<CoverPymtSeqB>()
                .Property(e => e.B52A_SWIFT)
                .IsFixedLength();

            modelBuilder.Entity<CoverPymtSeqB>()
                .Property(e => e.B56A_SWIFT)
                .IsFixedLength();

            modelBuilder.Entity<CoverPymtSeqB>()
                .Property(e => e.B57A_SWIFT)
                .IsFixedLength();

            modelBuilder.Entity<CoverPymtSeqB>()
                .Property(e => e.B59A_SWIFT)
                .IsFixedLength();

            modelBuilder.Entity<CoverPymtSeqB>()
                .Property(e => e.B70_SWIFT)
                .IsFixedLength();

            modelBuilder.Entity<CoverPymtSeqB>()
                .Property(e => e.B72_SWIFT)
                .IsFixedLength();

            modelBuilder.Entity<FedWireSVCInfo>()
                .Property(e => e.MsgDisposition_Version)
                .IsFixedLength();

            modelBuilder.Entity<FedWireSVCInfo>()
                .Property(e => e.MsgDisp_ProdCode)
                .IsFixedLength();

            modelBuilder.Entity<FedWireSVCInfo>()
                .Property(e => e.MsgDisp_DupCode)
                .IsFixedLength();

            modelBuilder.Entity<FedWireSVCInfo>()
                .Property(e => e.MsgDisp_Status)
                .IsFixedLength();

            modelBuilder.Entity<FedWireSVCInfo>()
                .Property(e => e.RcptTimeStamp_Date)
                .IsFixedLength();

            modelBuilder.Entity<FedWireSVCInfo>()
                .Property(e => e.RcptTimeStamp_Time)
                .IsFixedLength();

            modelBuilder.Entity<FedWireSVCInfo>()
                .Property(e => e.Rcpt_AppID)
                .IsFixedLength();

            modelBuilder.Entity<FedWireSVCInfo>()
                .Property(e => e.OMAD_CycleDate)
                .IsFixedLength();

            modelBuilder.Entity<FedWireSVCInfo>()
                .Property(e => e.OMAD_DestID)
                .IsFixedLength();

            modelBuilder.Entity<FedWireSVCInfo>()
                .Property(e => e.OMAD_SeqNum)
                .IsFixedLength();

            modelBuilder.Entity<FedWireSVCInfo>()
                .Property(e => e.OMAD_Date)
                .IsFixedLength();

            modelBuilder.Entity<FedWireSVCInfo>()
                .Property(e => e.OMAD_Time)
                .IsFixedLength();

            modelBuilder.Entity<FedWireSVCInfo>()
                .Property(e => e.OMAD_FRBID)
                .IsFixedLength();

            modelBuilder.Entity<FedWireSVCInfo>()
                .Property(e => e.Error_Category)
                .IsFixedLength();

            modelBuilder.Entity<FedWireSVCInfo>()
                .Property(e => e.Error_Code)
                .IsFixedLength();

            modelBuilder.Entity<FItoFI_Info>()
                .Property(e => e.DrawDbtAdv_Code)
                .IsFixedLength();

            modelBuilder.Entity<FItoFI_Info>()
                .Property(e => e.InterFIAdv_Code)
                .IsFixedLength();

            modelBuilder.Entity<FItoFI_Info>()
                .Property(e => e.BnfFIAdv_Code)
                .IsFixedLength();

            modelBuilder.Entity<FItoFI_Info>()
                .Property(e => e.MethodPmtBnf_Method)
                .IsFixedLength();

            modelBuilder.Entity<MandatoryField>()
                .Property(e => e.SSI_Format)
                .IsFixedLength();

            modelBuilder.Entity<MandatoryField>()
                .Property(e => e.SSI_URC)
                .IsFixedLength();

            modelBuilder.Entity<MandatoryField>()
                .Property(e => e.SSI_TPC)
                .IsFixedLength();

            modelBuilder.Entity<MandatoryField>()
                .Property(e => e.SSI_MDC)
                .IsFixedLength();

            modelBuilder.Entity<MandatoryField>()
                .Property(e => e.TypeCode)
                .IsFixedLength();

            modelBuilder.Entity<MandatoryField>()
                .Property(e => e.SubType)
                .IsFixedLength();

            modelBuilder.Entity<MandatoryField>()
                .Property(e => e.IMAD_ICD)
                .IsFixedLength();

            modelBuilder.Entity<MandatoryField>()
                .Property(e => e.IMAD_Source)
                .IsFixedLength();

            modelBuilder.Entity<MandatoryField>()
                .Property(e => e.IMAD_Seq)
                .IsFixedLength();

            modelBuilder.Entity<MandatoryField>()
                .Property(e => e.WireAmount)
                .IsFixedLength();

            modelBuilder.Entity<MandatoryField>()
                .Property(e => e.SenderDI_ABA)
                .IsFixedLength();

            modelBuilder.Entity<MandatoryField>()
                .Property(e => e.ReceiverDI_ABA)
                .IsFixedLength();

            modelBuilder.Entity<MandatoryField>()
                .Property(e => e.BusinessFunctionCode)
                .IsFixedLength();

            modelBuilder.Entity<MandatoryField>()
                .Property(e => e.TransactionTypeCode)
                .IsFixedLength();

            modelBuilder.Entity<OriginatorInfo>()
                .Property(e => e.Orig_ID)
                .IsFixedLength();

            modelBuilder.Entity<OriginatorInfo>()
                .Property(e => e.OrigFI_ID)
                .IsFixedLength();

            modelBuilder.Entity<OriginatorInfo>()
                .Property(e => e.InstructFI_ID)
                .IsFixedLength();

            modelBuilder.Entity<OriginatorInfo>()
                .Property(e => e.AcctCredDrawDown)
                .IsFixedLength();

            modelBuilder.Entity<OtherTransferInfo>()
                .Property(e => e.Local_Code)
                .IsFixedLength();

            modelBuilder.Entity<OtherTransferInfo>()
                .Property(e => e.Pymt_Notification_ID)
                .IsFixedLength();

            modelBuilder.Entity<OtherTransferInfo>()
                .Property(e => e.Charges_Details)
                .IsFixedLength();

            modelBuilder.Entity<OtherTransferInfo>()
                .Property(e => e.InstructedAmt_Code)
                .IsFixedLength();

            modelBuilder.Entity<RelatedRemitInfo>()
                .Property(e => e.RelRemit_Loc)
                .IsFixedLength();

            modelBuilder.Entity<RelatedRemitInfo>()
                .Property(e => e.RelRemit_AddrType)
                .IsFixedLength();

            modelBuilder.Entity<RelatedRemitInfo>()
                .Property(e => e.RelRemit_Country)
                .IsFixedLength();

            modelBuilder.Entity<StructRemitOnce>()
                .Property(e => e.RemitOrig_Type)
                .IsFixedLength();

            modelBuilder.Entity<StructRemitOnce>()
                .Property(e => e.RemitOrig_Code)
                .IsFixedLength();

            modelBuilder.Entity<StructRemitOnce>()
                .Property(e => e.RemitOrig_AddrType)
                .IsFixedLength();

            modelBuilder.Entity<StructRemitOnce>()
                .Property(e => e.RemitOrig_Country)
                .IsFixedLength();

            modelBuilder.Entity<StructRemitOnce>()
                .Property(e => e.RemitOrig_CountryRes)
                .IsFixedLength();

            modelBuilder.Entity<StructRemitOnce>()
                .Property(e => e.RemitBnf_)
                .IsFixedLength();

            modelBuilder.Entity<StructRemitOnce>()
                .Property(e => e.RemitBnf_Code)
                .IsFixedLength();

            modelBuilder.Entity<StructRemitOnce>()
                .Property(e => e.RemitBnf_AddrType)
                .IsFixedLength();

            modelBuilder.Entity<StructRemitOnce>()
                .Property(e => e.RemitBnf_Country)
                .IsFixedLength();

            modelBuilder.Entity<StructRemitOnce>()
                .Property(e => e.RemitBnf_CountryRes)
                .IsFixedLength();

            modelBuilder.Entity<StructRemitRepeat>()
                .Property(e => e.PrimRemit_DocType)
                .IsFixedLength();

            modelBuilder.Entity<StructRemitRepeat>()
                .Property(e => e.AmtPaid_CurrCode)
                .IsFixedLength();

            modelBuilder.Entity<StructRemitRepeat>()
                .Property(e => e.GrossAmtRemit_CurrCode)
                .IsFixedLength();

            modelBuilder.Entity<StructRemitRepeat>()
                .Property(e => e.AmtNegDisc_CurrCode)
                .IsFixedLength();

            modelBuilder.Entity<StructRemitRepeat>()
                .Property(e => e.AdjustInfo_RsnCode)
                .IsFixedLength();

            modelBuilder.Entity<StructRemitRepeat>()
                .Property(e => e.AdjustInfo_Indicator)
                .IsFixedLength();

            modelBuilder.Entity<StructRemitRepeat>()
                .Property(e => e.AdjustInfo_CurrCode)
                .IsFixedLength();

            modelBuilder.Entity<StructRemitRepeat>()
                .Property(e => e.DateOfRemitDoc)
                .IsFixedLength();

            modelBuilder.Entity<StructRemitRepeat>()
                .Property(e => e.SecRemit_Type)
                .IsFixedLength();

            modelBuilder.Entity<UnstructAddenda>()
                .Property(e => e.UA_Length)
                .IsFixedLength();

            modelBuilder.Entity<WireMain>()
                .Property(e => e.Status)
                .IsFixedLength();

            modelBuilder.Entity<WireMain>()
                .HasMany(e => e.BnfInfoes)
                .WithRequired(e => e.WireMain)
                .HasForeignKey(e => e.FK_WireID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WireMain>()
                .HasMany(e => e.CoverPymtSeqBs)
                .WithRequired(e => e.WireMain)
                .HasForeignKey(e => e.FK_WireID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WireMain>()
                .HasMany(e => e.FedWireSVCInfoes)
                .WithRequired(e => e.WireMain)
                .HasForeignKey(e => e.FK_WireID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WireMain>()
                .HasMany(e => e.FItoFI_Info)
                .WithRequired(e => e.WireMain)
                .HasForeignKey(e => e.FK_WireID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WireMain>()
                .HasMany(e => e.MandatoryFields)
                .WithRequired(e => e.WireMain)
                .HasForeignKey(e => e.FK_WireID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WireMain>()
                .HasMany(e => e.OriginatorInfoes)
                .WithRequired(e => e.WireMain)
                .HasForeignKey(e => e.FK_WireID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WireMain>()
                .HasMany(e => e.OtherTransferInfoes)
                .WithRequired(e => e.WireMain)
                .HasForeignKey(e => e.FK_WireID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WireMain>()
                .HasMany(e => e.RelatedRemitInfoes)
                .WithRequired(e => e.WireMain)
                .HasForeignKey(e => e.FK_WireID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WireMain>()
                .HasMany(e => e.StructRemitOnces)
                .WithRequired(e => e.WireMain)
                .HasForeignKey(e => e.FK_WireID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WireMain>()
                .HasMany(e => e.StructRemitRepeats)
                .WithRequired(e => e.WireMain)
                .HasForeignKey(e => e.FK_WireID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WireMain>()
                .HasMany(e => e.SVCInfoes)
                .WithRequired(e => e.WireMain)
                .HasForeignKey(e => e.FK_WireID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WireMain>()
                .HasMany(e => e.UnstructAddendas)
                .WithRequired(e => e.WireMain)
                .HasForeignKey(e => e.FK_WireID)
                .WillCascadeOnDelete(false);
        }
    }
}
