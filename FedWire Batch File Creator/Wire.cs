﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;

namespace FedWire_Batch_File_Creator
{
    public class Wire
    {

        public Wire(UserAccess currentUser, int currentBatchID)
        {
            AssignDefaultWireValues(currentUser, currentBatchID);
            AssignNewWireID();
        }

        public void DestroyAllDBRef()
        {
            using (var context = new FWFCdbEntities())
            {
                var thiswire = context.WireMains.Where(c => c.WireID == this.WireID).Single();

                context.BnfInfoes.RemoveRange(context.BnfInfoes.Where(c => c.FK_WireID == thiswire.WireID));
                context.CoverPymtSeqBs.RemoveRange(context.CoverPymtSeqBs.Where(c => c.FK_WireID == thiswire.WireID));
                context.FedWireSVCInfoes.RemoveRange(context.FedWireSVCInfoes.Where(c => c.FK_WireID == thiswire.WireID));
                context.FItoFI_Info.RemoveRange(context.FItoFI_Info.Where(c => c.FK_WireID == thiswire.WireID));
                context.MandatoryFields.RemoveRange(context.MandatoryFields.Where(c => c.FK_WireID == thiswire.WireID));
                context.OriginatorInfoes.RemoveRange(context.OriginatorInfoes.Where(c => c.FK_WireID == thiswire.WireID));
                context.OtherTransferInfoes.RemoveRange(context.OtherTransferInfoes.Where(c => c.FK_WireID == thiswire.WireID));
                context.RelatedRemitInfoes.RemoveRange(context.RelatedRemitInfoes.Where(c => c.FK_WireID == thiswire.WireID));
                context.StructRemitOnces.RemoveRange(context.StructRemitOnces.Where(c => c.FK_WireID == thiswire.WireID));
                context.StructRemitRepeats.RemoveRange(context.StructRemitRepeats.Where(c => c.FK_WireID == thiswire.WireID));
                context.SVCInfoes.RemoveRange(context.SVCInfoes.Where(c => c.FK_WireID == thiswire.WireID));
                context.UnstructAddendas.RemoveRange(context.UnstructAddendas.Where(c => c.FK_WireID == thiswire.WireID));
                context.WireMains.Remove(thiswire);

                Debug.WriteLine("Removing Wire: " + thiswire.WireID.ToString());
                context.AttemptSaveChanges();
            }
        }

        private void AssignDefaultWireValues(UserAccess currentUser, int currentBatchID)
        {
            Status = "UNVF";
            InitiatedByUser = currentUser.thisUser.UserName;
            InitiatedByDateTime = DateTime.Now;
            ModifiedByUser = currentUser.thisUser.UserName;
            ModifiedByDateTime = DateTime.Now;
            FK_BatchID = currentBatchID;

            SSI_Format = "30";
            SSI_URC = "99999999"; // Placeholder - Based on Institution Profile
            SSI_TPC = "T"; // "T" for Test, "P" for Production
            SSI_MDC = " "; // " " for 'original message', "P" for 'resend'

            IMAD_ICD = DateTime.Now.ToString("yyyyMMdd");
            IMAD_Source = "QMGFT001"; // Placeholder - based on Sending Institution Profile
            IMAD_Seq = "000" + "000"; // Placeholder - Sequence number will be calculated field.

            SenderDI_ABA = "999999999"; // Placeholder - based on Sending Institution Profile
            SenderDI_ShortName = "THE BANK OF TEST"; // Placeholder - based on Sending Institution Profile
        }

        private void AssignNewWireID()
        {
            WireMain _wireID = new WireMain();

            using (var context = new FWFCdbEntities())
            {
                _wireID = new WireMain
                {
                    Init_DateTime = this.InitiatedByDateTime,
                    Init_UserName = this.InitiatedByUser,
                    Modified_DateTime = this.ModifiedByDateTime,
                    Modified_UserName = this.ModifiedByUser,
                    Status = this.Status,
                    FK_BatchID = this.FK_BatchID
                };
                context.WireMains.Add(_wireID);
                context.AttemptSaveChanges();
            }
            this.WireID = _wireID.WireID;
        }

        public void UpdateWireDB()
        {
            using (var context = new FWFCdbEntities())
            {
                var updateContext = context.WireMains.Where(c => c.WireID == this.WireID).First();
                updateContext.Modified_UserName = this.ModifiedByUser;
                updateContext.Modified_DateTime = DateTime.Now;
                updateContext.Status = this.Status;

                // Note:  Currently will add context fields even if no relevant data is present due to updateContext WireID mapping to FK.
                // Future update:  Needs logic to determine whether context.<SomeField>.Add() is necessary.
                context.MandatoryFields.Add(GetAllMandatoryField(thiswire: updateContext));
                context.BnfInfoes.Add(GetAllBnfInfo(updateContext));
                context.OtherTransferInfoes.Add(GetAllOtherTransferInfo(thiswire: updateContext));
                context.OriginatorInfoes.Add(GetAllOriginatorInfo(thiswire: updateContext));
                context.FItoFI_Info.Add(GetAllFItoFI_Info(thiswire: updateContext));
                context.CoverPymtSeqBs.Add(GetAllCoverPymtSeqB(thiswire: updateContext));
                context.UnstructAddendas.Add(GetAllUnstructAddenda(thiswire: updateContext));
                context.RelatedRemitInfoes.Add(GetAllRelatedRemitInfo(thiswire: updateContext));
                context.StructRemitOnces.Add(GetAllStructRemitOnce(thiswire: updateContext));
                context.StructRemitRepeats.Add(GetAllStructRemitRepeat(thiswire: updateContext)); // Note: StructRemitRepeat requires loop logic
                context.SVCInfoes.Add(GetAllSVCInfo(thiswire: updateContext));
                context.FedWireSVCInfoes.Add(GetAllFedWireSVCInfo(thiswire: updateContext));

                try
                { 
                    context.AttemptSaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var entityValidationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in entityValidationErrors.ValidationErrors)
                        {
                            Debug.WriteLine("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                        }
                    }
                }

            }
        }

        private MandatoryField GetAllMandatoryField(WireMain thiswire)
        {
            Debug.WriteLine("Writing new MandatoryField entry to DB.");
            return new MandatoryField
            {
                SSI_Format = this.SSI_Format,
                SSI_MDC = this.SSI_MDC,
                SSI_TPC = this.SSI_TPC,
                SSI_URC = this.SSI_URC,

                TypeCode = this.TypeCode,
                SubType = this.SubType,

                IMAD_ICD = this.IMAD_ICD,
                IMAD_Seq = this.IMAD_Seq,
                IMAD_Source = this.IMAD_Source,

                WireAmount = this.WireAmount,

                SenderDI_ABA = this.SenderDI_ABA,
                SenderDI_ShortName = this.SenderDI_ShortName,

                ReceiverDI_ABA = this.ReceiverDI_ShortName,
                ReceiverDI_ShortName = this.ReceiverDI_ShortName,

                BusinessFunctionCode = this.BusinessFunctionCode,
                TransactionTypeCode = this.TransactionTypeCode,

                FK_WireID = thiswire.WireID
            };
        }

        private BnfInfo GetAllBnfInfo(WireMain thiswire)
        {
            Debug.WriteLine("Writing new BnfInfo entry to DB.");
            return new BnfInfo
            {
                InterFI_ID = this.InterFI_ID,
                InterFI_Name = this.InterFI_Name,
                InterFI_Addr1 = this.InterFI_Addr1,
                InterFI_Addr2 = this.InterFI_Addr2,
                InterFI_Addr3 = this.InterFI_Addr3,
                InterFI_Ident = this.InterFI_Ident,

                BenFI_ID = this.BenFI_ID,
                BenFI_Addr1 = this.BenFI_Addr1,
                BenFI_Addr2 = this.BenFI_Addr2,
                BenFI_Addr3 = this.BenFI_Addr3,
                BenFI_Ident = this.BenFI_Ident,
                BenFI_Name = this.BenFI_Name,

                Bnf_ID = this.Bnf_ID,
                Bnf_Ident = this.Bnf_Ident,
                Bnf_Name = this.Bnf_Name,
                Bnf_Addr1 = this.Bnf_Addr1,
                Bnf_Addr2 = this.Bnf_Addr2,
                Bnf_Addr3 = this.Bnf_Addr3,

                BnfRef = this.BnfRef,

                AcctDbtDraw_Addr1 = this.AcctDbtDraw_Addr1,
                AcctDbtDraw_Addr2 = this.AcctDbtDraw_Addr2,
                AcctDbtDraw_Addr3 = this.AcctDbtDraw_Addr3,
                AcctDbtDraw_ID = this.AcctDbtDraw_ID,
                AcctDbtDraw_Ident = this.AcctDbtDraw_Ident,
                AcctDbtDraw_Name = this.AcctDbtDraw_Name,

                FK_WireID = thiswire.WireID
            };
        }

        private OtherTransferInfo GetAllOtherTransferInfo(WireMain thiswire)
        {
            Debug.WriteLine("Writing new OtherTransferInfo entry to DB.");
            return new OtherTransferInfo
            {
                SenderRef = this.SenderRef,
                PrevMsgID = this.PrevMsgID,

                Local_Code = this.Local_Code,
                Local_PropCode = this.Local_Code,

                Pymt_Notification_ID = this.Pymt_Notification_ID,
                Pymt_ContactFaxNum = this.Pymt_ContactFaxNum,
                Pymt_ContactMobileNum = this.Pymt_ContactMobile,
                Pymt_ContactName = this.Pymt_ContactName,
                Pymt_ContactPhoneNum = this.Pymt_ContactPhoneNum,
                Pymt_Electronic_Addr = this.Pymt_Electronic_Addr,
                Pymt_EndNotification = this.Pymt_EndNotification,

                Charges_Details = this.Charges_Details,
                Charges_SendersF1 = this.Charges_SendersF1,
                Charges_SendersF2 = this.Charges_SendersF2,
                Charges_SendersF3 = this.Charges_SendersF3,
                Charges_SendersF4 = this.Charges_SendersF4,

                InstructedAmt_Code = this.InstructedAmtCode,
                InstructedAmt_Amt = this.InstructedAmt_Amt,

                ExchangeRate = this.ExchangeRate,

                FK_WireID = thiswire.WireID
            };
        }

        private OriginatorInfo GetAllOriginatorInfo(WireMain thiswire)
        {
            Debug.WriteLine("Writing new OriginatorInfo entry to DB.");
            return new OriginatorInfo
            {
                Orig_ID = this.Orig_ID,
                Orig_Name = this.Orig_Name,
                Orig_Ident = this.Orig_Ident,
                Orig_Addr1 = this.Orig_Addr1,
                Orig_Addr2 = this.Orig_Addr2,
                Orig_Addr3 = this.Orig_Addr3,

                OrigOptF_ID = this.OrigOptF_ID,
                OrigOptF_Name = this.OrigOptF_Name,
                OrigOptF_L1 = this.OrigOptF_L1,
                OrigOptF_L2 = this.OrigOptF_L2,
                OrigOptF_L3 = this.OrigOptF_L3,

                OrigFI_ID = this.OrigFI_ID,
                OrigFI_Name = this.OrigFI_Name,
                OrigFI_Ident = this.OrigFI_Ident,
                OrigFI_Addr1= this.OrigFI_Addr1,
                OrigFI_Addr2 = this.OrigFI_Addr2,
                OrigFI_Addr3 = this.OrigFI_Addr3,
                
                InstructFI_ID = this.InstructFI_ID,
                InstructFI_Name = this.InstructFI_Name,
                InstructFI_Ident = this.InstructFI_Ident,
                InstructFI_Addr1 = this.InstructFI_Addr1,
                InstructFI_Addr2 = this.InstructFI_Addr2,
                InstructFI_Addr3 = this.InstructFI_Addr3,

                AcctCredDrawDown = this.AcctCredDrawDown,
                
                OBI_L1 = this.OBI_L1,
                OBI_L2 = this.OBI_L2,
                OBI_L3 = this.OBI_L3,
                OBI_L4 = this.OBI_L4,

                FK_WireID = thiswire.WireID
            };
        }

        private FItoFI_Info GetAllFItoFI_Info(WireMain thiswire)
        {
            Debug.WriteLine("Writing new FItoFI_Info to the DB.");
            return new FItoFI_Info
            {
                FIFI_RecInfo1 = this.FIFI_RecInfo1,
                FIFI_RecInfo2 = this.FIFI_RecInfo2,
                FIFI_RecInfo3 = this.FIFI_RecInfo3,
                FIFI_RecInfo4 = this.FIFI_RecInfo4,
                FIFI_RecInfo5 = this.FIFI_RecInfo5,
                FIFI_RecInfo6 = this.FIFI_RecInfo6,

                DrawDbtAdv_Code = this.DrawDbtAdv_Code,
                DrawDbtAdv_Info1 = this.DrawDbtAdv_Info1,
                DrawDbtAdv_Info2 = this.DrawDbtAdv_Info2,
                DrawDbtAdv_Info3 = this.DrawDbtAdv_Info3,
                DrawDbtAdv_Info4 = this.DrawDbtAdv_Info4,
                DrawDbtAdv_Info5 = this.DrawDbtAdv_Info5,
                DrawDbtAdv_Info6 = this.DrawDbtAdv_Info6,

                InterFI_Info1 = this.InterFI_Info1,
                InterFI_Info2 = this.InterFI_Info2,
                InterFI_Info3 = this.InterFI_Info3,
                InterFI_Info4 = this.InterFI_Info4,
                InterFI_Info5 = this.InterFI_Info5,
                InterFI_Info6 = this.InterFI_Info6,

                InterFIAdv_Code = this.InterFIAdv_Code,
                InterFIAdv_Info1 = this.InterFIAdv_Info1,
                InterFIAdv_Info2 = this.InterFIAdv_Info2,
                InterFIAdv_Info3 = this.InterFIAdv_Info3,
                InterFIAdv_Info4 = this.InterFIAdv_Info4,
                InterFIAdv_Info5 = this.InterFIAdv_Info5,
                InterFIAdv_Info6 = this.InterFIAdv_Info6,

                BnfFI_Info1 = this.BnfFI_Info1,
                BnfFI_Info2 = this.BnfFI_Info2,
                BnfFI_Info3 = this.BnfFI_Info3,
                BnfFI_Info4 = this.BnfFI_Info4,
                BnfFI_Info5 = this.BnfFI_Info5,
                BnfFI_Info6 = this.BnfFI_Info6,

                BnfFIAdv_Code = this.BnfFIAdv_Code,
                BnfFIAdv_Info1 = this.BnfFIAdv_Info1,
                BnfFIAdv_Info2 = this.BnfFIAdv_Info2,
                BnfFIAdv_Info3 = this.BnfFIAdv_Info3,
                BnfFIAdv_Info4 = this.BnfFIAdv_Info4,
                BnfFIAdv_Info5 = this.BnfFIAdv_Info5,
                BnfFIAdv_Info6 = this.BnfFIAdv_Info6,

                Bnf_Info1 = this.Bnf_Info1,
                Bnf_Info2 = this.Bnf_Info2,
                Bnf_Info3 = this.Bnf_Info3,
                Bnf_Info4 = this.Bnf_Info4,
                Bnf_Info5 = this.Bnf_Info5,
                Bnf_Info6 = this.Bnf_Info6,

                BnfAdv_Code = this.BnfAdv_Code,
                BnfAdv_Info1 = this.BnfAdv_Info1,
                BnfAdv_Info2 = this.BnfAdv_Info2,
                BnfAdv_Info3 = this.BnfAdv_Info3,
                BnfAdv_Info4 = this.BnfAdv_Info4,
                BnfAdv_Info5 = this.BnfAdv_Info5,
                BnfAdv_Info6 = this.BnfAdv_Info6,

                MethodPmtBnf_Info = this.MethodPmtBnf_Info,
                MethodPmtBnf_Method = this.MethodPmtBnf_Method,

                FI_to_FI_Info1 = this.FI_to_FI_Info1,
                FI_to_FI_Info2 = this.FI_to_FI_Info2,
                FI_to_FI_Info3 = this.FI_to_FI_Info3,
                FI_to_FI_Info4 = this.FI_to_FI_Info4,
                FI_to_FI_Info5 = this.FI_to_FI_Info5,
                FI_to_FI_Info6 = this.FI_to_FI_Info6,

                FK_WireID = thiswire.WireID
            };
        }

        private CoverPymtSeqB GetAllCoverPymtSeqB(WireMain thiswire)
        {
            Debug.WriteLine("Writing new CoverPymtSeqB to the DB.");
            return new CoverPymtSeqB
            {
                B33B_SWIFT = this.B33B_SWIFT,
                B33B_Amt = this.B33B_Amt,

                B50A_SWIFT = this.B50A_SWIFT,
                B50A_L1 = this.B50A_L1,
                B50A_L2 = this.B50A_L2,
                B50A_L3 = this.B50A_L3,
                B50A_L4 = this.B50A_L4,
                B50A_L5 = this.B50A_L5,
                
                B52A_SWIFT = this.B52A_SWIFT,
                B52A_L1 = this.B52A_L1,
                B52A_L2 = this.B52A_L2, 
                B52A_L3 = this.B52A_L3,
                B52A_L4 = this.B52A_L4,
                B52A_L5 = this.B52A_L5,

                B56A_SWIFT = this.B56A_SWIFT,
                B56A_L1 = this.B56A_L1,
                B56A_L2 = this.B56A_L2,
                B56A_L3 = this.B56A_L3,
                B56A_L4 = this.B56A_L4,
                B56A_L5 = this.B56A_L5,

                B57A_SWIFT = this.B57A_SWIFT,
                B57A_L1 = this.B57A_L1,
                B57A_L2 = this.B57A_L2,
                B57A_L3 = this.B57A_L3,
                B57A_L4 = this.B57A_L4,
                B57A_L5 = this.B57A_L5,

                B59A_SWIFT = this.B59A_SWIFT,
                B59A_L1 = this.B59A_L1,
                B59A_L2 = this.B59A_L2,
                B59A_L3 = this.B59A_L3,
                B59A_L4 = this.B59A_L4,
                B59A_L5 = this.B59A_L5,

                B70_SWIFT = this.B70_SWIFT,
                B70_L1 = this.B70_L1,
                B70_L2 = this.B70_L2,
                B70_L3 = this.B70_L3,
                B70_L4 = this.B70_L4,

                B72_SWIFT = this.B72_SWIFT,
                B72_L1 = this.B72_L1,
                B72_L2 = this.B72_L2,
                B72_L3 = this.B72_L3,
                B72_L4 = this.B72_L4,
                B72_L5 = this.B72_L5,
                B72_L6 = this.B72_L6,

                CoverPymt_ID = thiswire.WireID
            };
        }

        private UnstructAddenda GetAllUnstructAddenda(WireMain thiswire)
        {
            Debug.WriteLine("Writing new UnstructAddenda to the DB.");
            return new UnstructAddenda
            {
                UA_Length = this.UA_Length,
                UA_Info1 = this.UA_Info1,
                UA_Info2 = this.UA_Info2,
                UA_Info3 = this.UA_Info3,
                UA_Info4 = this.UA_Info4,
                UA_Info5 = this.UA_Info5,
                UA_Info6 = this.UA_Info6,
                UA_Info7 = this.UA_Info7,
                UA_Info8 = this.UA_Info8,
                UA_Info9 = this.UA_Info9,
                
                FK_WireID = thiswire.WireID
            };
        }

        private RelatedRemitInfo GetAllRelatedRemitInfo(WireMain thiswire)
        {
            Debug.WriteLine("Writing new RelatedRemitInfo to the DB.");
            return new RelatedRemitInfo
            {
                RelRemit_ID = this.RelRemit_ID,
                RelRemit_Loc = this.RelRemit_Loc,
                RemitLoc_ElecAddr = this.RelRemit_ElecAddr, // Note: EF entity (and related DB table entity) RemitLoc_ElecAddr reqs rename to RelRemit_ElecAddr
                RelRemit_Name = this.RelRemit_Name,
                RelRemit_AddrType = this.RelRemit_AddrType,
                RelRemit_Dept = this.RelRemit_Dept,
                RelRemit_SubDept = this.RelRemit_SubDept,
                RelRemit_StrName = this.RelRemit_StrName,
                RelRemit_BldgNum = this.RelRemit_BldgNum,
                RelRemit_PostCode = this.RelRemit_PostCode,
                RelRemit_TownName = this.RelRemit_TownName,
                RelRemit_CountrySubDiv = this.RelRemit_CountrySubDiv,
                RelRemit_Country = this.RelRemit_Country,
                RelRemit_Addr1 = this.RelRemit_Addr1,
                RelRemit_Addr2 = this.RelRemit_Addr2,
                RelRemit_Addr3 = this.RelRemit_Addr3,
                RelRemit_Addr4 = this.RelRemit_Addr4,
                RelRemit_Addr5 = this.RelRemit_Addr5,
                RelRemit_Addr6 = this.RelRemit_Addr6,
                RelRemit_Addr7 = this.RelRemit_Addr7,

                FK_WireID = thiswire.WireID
            };
        }

        private StructRemitOnce GetAllStructRemitOnce(WireMain thiswire)
        {
            Debug.WriteLine("Writing new StructRemitOnce to the DB.");
            return new StructRemitOnce
            {
                RemitOrig_Type = this.RemitOrig_Type,
                RemitOrig_Code = this.RemitOrig_Code,
                RemitOrig_Name = this.RemitOrig_Name,
                RemitOrig_IDNum = this.RemitOrig_IDNum,
                RemitOrig_IDNumIss = this.RemitOrig_IDNumIss,
                RemitOrig_Birth = this.RemitOrig_Birth,
                RemitOrig_AddrType = this.RemitOrig_AddrType,
                RemitOrig_Dept = this.RemitOrig_Dept,
                RemitOrig_SubDept = this.RemitOrig_SubDept,
                RemitOrig_StreetName = this.RemitOrig_StreetName,
                RemitOrig_BldgNum = this.RemitOrig_BldgNum,
                RemitOrig_PostCode = this.RemitOrig_PostCode,
                RemitOrig_TownName = this.RemitOrig_TownName,
                RemitOrig_CountrySub = this.RemitOrig_CountrySub,
                RemitOrig_Country = this.RemitOrig_Country,
                RemitOrig_Addr1 = this.RemitOrig_Addr1,
                RemitOrig_Addr2 = this.RemitOrig_Addr2,
                RemitOrig_Addr3 = this.RemitOrig_Addr3,
                RemitOrig_Addr4 = this.RemitOrig_Addr4,
                RemitOrig_Addr5 = this.RemitOrig_Addr5,
                RemitOrig_Addr6 = this.RemitOrig_Addr6,
                RemitOrig_Addr7 = this.RemitOrig_Addr7,
                RemitOrig_CountryRes = this.RemitOrig_CountryRes,
                RemitOrig_ContactName = this.RemitOrig_ContactName,
                RemitOrig_PhoneNum = this.RemitOrig_PhoneNum,
                RemitOrig_MobileNum = this.RemitOrig_MobileNum,
                RemitOrig_FaxNum = this.RemitOrig_FaxNum,
                RemitOrig_ContactElec = this.RemitOrig_ContactElec,
                RemitOrig_ContactOther = this.RemitOrig_ContactOther,

                RemitBnf_Name = this.RemitBnf_Name,
                RemitBnf_Type = this.RemitBnf_Type,
                RemitBnf_Code = this.RemitBnf_Code,
                RemitBnf_IDNum = this.RemitBnf_IDNum,
                RemitBnf_IDNumIss = this.RemitBnf_IDNumIss,
                RemitBnf_Birth = this.RemitBnf_Birth,
                RemitBnf_AddrType = this.RemitBnf_AddrType,
                RemitBnf_Dept = this.RemitBnf_Dept,
                RemitBnf_SubDept = this.RemitBnf_SubDept,
                RemitBnf_StreetName = this.RemitBnf_StreetName,
                RemitBnf_BldgNum = this.RemitBnf_BldgNum,
                RemitBnf_PostCode = this.RemitBnf_PostCode,
                RemitBnf_TownName = this.RemitBnf_TownName,
                RemitBnf_CountrySub = this.RemitBnf_CountrySub,
                RemitBnf_Country = this.RemitBnf_Country,
                RemitBnf_Addr1 = this.RemitBnf_Addr1,
                RemitBnf_Addr2 = this.RemitBnf_Addr2,
                RemitBnf_Addr3 = this.RemitBnf_Addr3,
                RemitBnf_Addr4 = this.RemitBnf_Addr4,
                RemitBnf_Addr5 = this.RemitBnf_Addr5,
                RemitBnf_Addr6 = this.RemitBnf_Addr6,
                RemitBnf_Addr7 = this.RemitBnf_Addr7,
                RemitBnf_CountryRes = this.RemitBnf_CountryRes,
                
                FK_WireID = thiswire.WireID
            };
        }

        private StructRemitRepeat GetAllStructRemitRepeat(WireMain thiswire)
        {
            Debug.WriteLine("Writing new StructRemitRepeat to the DB.");
            return new StructRemitRepeat
            {
                PrimRemit_DocType = this.PrimRemit_DocType,
                PrimRemit_PropDocType = this.PrimRemit_PropDocType,
                PrimRemit_DocID = this.PrimRemit_DocID,
                PrimRemit_Issuer = this.PrimRemit_Issuer,

                AmtPaid_CurrCode = this.AmtPaid_CurrCode,
                AmtPaid_Amount = this.AmtPaid_Amount,

                GrossAmtRemit_CurrCode = this.GrossAmtRemit_CurrCode,
                GrossAmtRemit_Amount = this.GrossAmtRemit_Amount,

                AmtNegDisc_CurrCode = this.AmtNegDisc_CurrCode,
                AmtNegDisc_Amount = this.AmtNegDisc_Amount,

                AdjustInfo_RsnCode = this.AdjustInfo_RsnCode,
                AdjustInfo_Indicator = this.AdjustInfo_Indicator,
                AdjustInfo_CurrCode = this.AdjustInfo_CurrCode,
                AdjustInfo_Amount = this.AdjustInfo_Amount,
                AdjustInfo_Info = this.AdjustInfo_Info,

                DateOfRemitDoc = this.DateOfRemitDoc,

                SecRemit_Type = this.SecRemit_Type,
                SecRemit_PropDocType = this.SecRemit_PropDocType,
                SecRemit_Issuer = this.SecRemit_Issuer,
                SecRemit_DocID = this.SecRemit_DocID,

                Remit_FreeText1 = this.Remit_FreeText1,
                Remit_FreeText2 = this.Remit_FreeText2,
                Remit_FreeText3 = this.Remit_FreeText3,
                
                FK_WireID = thiswire.WireID

            };
        }

        private SVCInfo GetAllSVCInfo(WireMain thiswire)
        {
            Debug.WriteLine("Writing new SVCInfo to the DB.");
            return new SVCInfo
            {
                SVCInfo_L1 = this.SVCInfo_L1,
                SVCInfo_L2 = this.SVCInfo_L2,
                SVCInfo_L3 = this.SVCInfo_L3,
                SVCInfo_L4 = this.SVCInfo_L4,
                SVCInfo_L5 = this.SVCInfo_L5,
                SVCInfo_L6 = this.SVCInfo_L6,
                SVCInfo_L7 = this.SVCInfo_L7,
                SVCInfo_L8 = this.SVCInfo_L8,
                SVCInfo_L9 = this.SVCInfo_L9,
                SVCInfo_L10 = this.SVCInfo_L10,
                SVCInfo_L11 = this.SVCInfo_L11,
                SVCInfo_L12 = this.SVCInfo_L12,

                FK_WireID = thiswire.WireID
            };
        }

        private FedWireSVCInfo GetAllFedWireSVCInfo(WireMain thiswire)
        {
            Debug.WriteLine("Writing new FedWireSVCInfo to the DB.");
            return new FedWireSVCInfo
            {
                MsgDisposition_Version = this.MsgDisp_Version,
                MsgDisp_ProdCode = this.MsgDisp_ProdCode,
                MsgDisp_DupCode = this.MsgDisp_DupCode,
                MsgDisp_Status = this.MsgDisp_Status,

                RcptTimeStamp_Date = this.RcptTimeStamp_Date,
                RcptTimeStamp_Time = this.RcptTimeStamp_Time,
                Rcpt_AppID = this.Rcpt_AppID,

                OMAD_CycleDate = this.OMAD_CycleDate,
                OMAD_DestID = this.OMAD_DestID,
                OMAD_SeqNum = this.OMAD_SeqNum,
                OMAD_Date = this.OMAD_Date,
                OMAD_Time = this.OMAD_Time,
                OMAD_FRBID = this.OMAD_FRBID,

                Error_Category = this.Error_Category,
                Error_Code = this.Error_Code,
                Error_Desc = this.Error_Desc,

                FK_WireID = thiswire.WireID
            };
        }


        // **** USER, CREATION, AND MODIFICATION INFORMATION ****
        public int WireID { get; set; }
        public int FK_BatchID { get; set; }
        public string InitiatedByUser { get; set; }
        public DateTime InitiatedByDateTime { get; set; }
        public string ModifiedByUser { get; set; }
        public DateTime ModifiedByDateTime { get; set; }
        public string VerifiedByUser { get; set; }
        public DateTime VerifiedByTime { get; set; }
        public string Status { get; set; }




        // **** MANDATORY TAGS FOR ALL TRANSFERS ****
        // {1500} Sender Supplied Information
        public string SSI_Format { get; set; }
        public string SSI_URC { get; set; }
        public string SSI_TPC { get; set; }
        public string SSI_MDC { get; set; }

        // {1510} Type/SubType
        public string TypeCode { get; set; }
        public string SubType { get; set; }

        // {1520} Input Message Accountability Data (IMAD)
        public string IMAD_ICD { get; set; }
        public string IMAD_Source { get; set; }
        public string IMAD_Seq { get; set; }

        // {2000} Amount
        public decimal WireAmount { get; set; }

        // {3100} Sender DI
        public string SenderDI_ABA { get; set; }
        public string SenderDI_ShortName { get; set; }

        // {3400} Receiver DI
        public string RecieverDI_ABA { get; set; }
        public string ReceiverDI_ShortName { get; set; }

        // {3600} Business Function Code
        public string BusinessFunctionCode { get; set; }
        public string TransactionTypeCode { get; set; }


        // **** OTHER TRANSFER INFORMATION ****
        // {3320} Sender Reference
        public string SenderRef { get; set; }

        // {3500} Previous Message Identifier
        public string PrevMsgID { get; set; }

        // {3610} Local Instrument
        public string Local_Code { get; set; }
        public string LocalPropCode { get; set; }

        // {3620} Payment Notification
        public string Pymt_Notification_ID { get; set; }
        public string Pymt_Electronic_Addr { get; set; }
        public string Pymt_ContactName { get; set; }
        public string Pymt_ContactPhoneNum { get; set; }
        public string Pymt_ContactMobile { get; set; }
        public string Pymt_ContactFaxNum { get; set; }
        public string Pymt_EndNotification { get; set; }

        // {3700} Charges
        public string Charges_Details { get; set; }
        public string Charges_SendersF1 { get; set; }
        public string Charges_SendersF2 { get; set; }
        public string Charges_SendersF3 { get; set; }
        public string Charges_SendersF4 { get; set; }

        // {3710} Instructed Amount
        public string InstructedAmtCode { get; set; }
        public string InstructedAmt_Amt { get; set; }

        // {3720} Exchange Rate
        public string ExchangeRate { get; set; }


        // **** BENEFICIARY INFORMATION ****
        // {4000} Intermediary FI
        public string InterFI_ID { get; set; }
        public string InterFI_Ident { get; set; }
        public string InterFI_Name { get; set; }
        public string InterFI_Addr1 { get; set; }
        public string InterFI_Addr2 { get; set; }
        public string InterFI_Addr3 { get; set; }

        // {4100} Beneficiary FI
        public string BenFI_ID { get; set; }
        public string BenFI_Ident { get; set; }
        public string BenFI_Name { get; set; }
        public string BenFI_Addr1 { get; set; }
        public string BenFI_Addr2 { get; set; }
        public string BenFI_Addr3 { get; set; }

        // {4200} Beneficiary
        public string Bnf_ID { get; set; }
        public string Bnf_Ident { get; set; }
        public string Bnf_Name { get; set; }
        public string Bnf_Addr1 { get; set; }
        public string Bnf_Addr2 { get; set; }
        public string Bnf_Addr3 { get; set; }

        // {4320} Reference for Beneficiary
        public string BnfRef { get; set; }

        // {4400} Account Debited in Drawdown
        public string AcctDbtDraw_ID { get; set; }
        public string AcctDbtDraw_Ident { get; set; }
        public string AcctDbtDraw_Name { get; set; }
        public string AcctDbtDraw_Addr1 { get; set; }
        public string AcctDbtDraw_Addr2 { get; set; }
        public string AcctDbtDraw_Addr3 { get; set; }


        // **** ORIGINATOR INFORMATION ****
        // {5000} Originator
        public string Orig_ID { get; set; }
        public string Orig_Ident { get; set; }
        public string Orig_Name { get; set; }
        public string Orig_Addr1 { get; set; }
        public string Orig_Addr2 { get; set; }
        public string Orig_Addr3 { get; set; }

        // {5010} Originator Option F
        public string OrigOptF_ID { get; set; }
        public string OrigOptF_Name { get; set; }
        public string OrigOptF_L1 { get; set; }
        public string OrigOptF_L2 { get; set; }
        public string OrigOptF_L3 { get; set; }

        // {5100} Originator FI
        public string OrigFI_ID { get; set; }
        public string OrigFI_Ident { get; set; }
        public string OrigFI_Name { get; set; }
        public string OrigFI_Addr1 { get; set; }
        public string OrigFI_Addr2 { get; set; }
        public string OrigFI_Addr3 { get; set; }

        // {5200} Instructing FI
        public string InstructFI_ID { get; set; }
        public string InstructFI_Ident { get; set; }
        public string InstructFI_Name { get; set; }
        public string InstructFI_Addr1 { get; set; }
        public string InstructFI_Addr2 { get; set; }
        public string InstructFI_Addr3 { get; set; }

        // {5400} Account Credited in Drawdown
        public string AcctCredDrawDown { get; set; }

        // {6000} Originator to Beneficiary Information 
        public string OBI_L1 { get; set; }
        public string OBI_L2 { get; set; }
        public string OBI_L3 { get; set; }
        public string OBI_L4 { get; set; }


        // **** FINANCIAL INSTITUTION TO FINANCIAL INSTITUTION INFORMATION ****
        // {6100} Receiver FI Information
        public string FIFI_RecInfo1 { get; set; }
        public string FIFI_RecInfo2 { get; set; }
        public string FIFI_RecInfo3 { get; set; }
        public string FIFI_RecInfo4 { get; set; }
        public string FIFI_RecInfo5 { get; set; }
        public string FIFI_RecInfo6 { get; set; }

        // {6110} Drawdown Debit Advice Information
        public string DrawDbtAdv_Code { get; set; }
        public string DrawDbtAdv_Info1 { get; set; }
        public string DrawDbtAdv_Info2 { get; set; }
        public string DrawDbtAdv_Info3 { get; set; }
        public string DrawDbtAdv_Info4 { get; set; }
        public string DrawDbtAdv_Info5 { get; set; }
        public string DrawDbtAdv_Info6 { get; set; }

        // {6200} Intermediary FI Information
        public string InterFI_Info1 { get; set; }
        public string InterFI_Info2 { get; set; }
        public string InterFI_Info3 { get; set; }
        public string InterFI_Info4 { get; set; }
        public string InterFI_Info5 { get; set; }
        public string InterFI_Info6 { get; set; }

        // {6210} Intermediary FI Advice Information
        public string InterFIAdv_Code { get; set; }
        public string InterFIAdv_Info1 { get; set; }
        public string InterFIAdv_Info2 { get; set; }
        public string InterFIAdv_Info3 { get; set; }
        public string InterFIAdv_Info4 { get; set; }
        public string InterFIAdv_Info5 { get; set; }
        public string InterFIAdv_Info6 { get; set; }

        // {6300} Beneficiary's FI Information
        public string BnfFI_Info1 { get; set; }
        public string BnfFI_Info2 { get; set; }
        public string BnfFI_Info3 { get; set; }
        public string BnfFI_Info4 { get; set; }
        public string BnfFI_Info5 { get; set; }
        public string BnfFI_Info6 { get; set; }

        // {6310} Beneficiary's FI Advice Information
        public string BnfFIAdv_Code { get; set; }
        public string BnfFIAdv_Info1 { get; set; }
        public string BnfFIAdv_Info2 { get; set; }
        public string BnfFIAdv_Info3 { get; set; }
        public string BnfFIAdv_Info4 { get; set; }
        public string BnfFIAdv_Info5 { get; set; }
        public string BnfFIAdv_Info6 { get; set; }

        // {6400} Beneficiary Information
        public string Bnf_Info1 { get; set; }
        public string Bnf_Info2 { get; set; }
        public string Bnf_Info3 { get; set; }
        public string Bnf_Info4 { get; set; }
        public string Bnf_Info5 { get; set; }
        public string Bnf_Info6 { get; set; }

        // {6410} Beneficiary Advice Information
        public string BnfAdv_Code { get; set; }
        public string BnfAdv_Info1 { get; set; }
        public string BnfAdv_Info2 { get; set; }
        public string BnfAdv_Info3 { get; set; }
        public string BnfAdv_Info4 { get; set; }
        public string BnfAdv_Info5 { get; set; }
        public string BnfAdv_Info6 { get; set; }

        // {6420} Method of Payment to Beneficiary
        public string MethodPmtBnf_Method { get; set; }
        public string MethodPmtBnf_Info { get; set; }

        // {6500} FI to FI Information
        public string FI_to_FI_Info1 { get; set; }
        public string FI_to_FI_Info2 { get; set; }
        public string FI_to_FI_Info3 { get; set; }
        public string FI_to_FI_Info4 { get; set; }
        public string FI_to_FI_Info5 { get; set; }
        public string FI_to_FI_Info6 { get; set; }


        // **** COVER PAYMENT INFORMATION ****
        // {7033} Sequence B 33B Currency/Instructed Amount
        public string B33B_SWIFT { get; set; }
        public string B33B_Amt { get; set; }

        // {7050} Sequence B 50a Ordering Customer
        public string B50A_SWIFT { get; set; }
        public string B50A_L1 { get; set; }
        public string B50A_L2 { get; set; }
        public string B50A_L3 { get; set; }
        public string B50A_L4 { get; set; }
        public string B50A_L5 { get; set; }

        // {7052} Sequence B 52a Ordering Institution
        public string B52A_SWIFT { get; set; }
        public string B52A_L1 { get; set; }
        public string B52A_L2 { get; set; }
        public string B52A_L3 { get; set; }
        public string B52A_L4 { get; set; }
        public string B52A_L5 { get; set; }

        // {7056} Sequence B 56a Intermediary Institution
        public string B56A_SWIFT { get; set; }
        public string B56A_L1 { get; set; }
        public string B56A_L2 { get; set; }
        public string B56A_L3 { get; set; }
        public string B56A_L4 { get; set; }
        public string B56A_L5 { get; set; }

        // {7057} Sequence B 57a Account with Institution
        public string B57A_SWIFT { get; set; }
        public string B57A_L1 { get; set; }
        public string B57A_L2 { get; set; }
        public string B57A_L3 { get; set; }
        public string B57A_L4 { get; set; }
        public string B57A_L5 { get; set; }

        // {7059} Sequence B 59a Beneficiary Customer
        public string B59A_SWIFT { get; set; }
        public string B59A_L1 { get; set; }
        public string B59A_L2 { get; set; }
        public string B59A_L3 { get; set; }
        public string B59A_L4 { get; set; }
        public string B59A_L5 { get; set; }

        // {7070} Sequence B 70 Remittance Information
        public string B70_SWIFT { get; set; }
        public string B70_L1 { get; set; }
        public string B70_L2 { get; set; }
        public string B70_L3 { get; set; }
        public string B70_L4 { get; set; }

        // {7072} Sequence B 72 Sender to Receiver Information
        public string B72_SWIFT { get; set; }
        public string B72_L1 { get; set; }
        public string B72_L2 { get; set; }
        public string B72_L3 { get; set; }
        public string B72_L4 { get; set; }
        public string B72_L5 { get; set; }
        public string B72_L6 { get; set; }


        // **** UNSTRUCTURED ADDENDA INFORMATION ****
        // {8200} Unstructured Addenda Information
        public string UA_Length { get; set; }
        public string UA_Info1 { get; set; }
        public string UA_Info2 { get; set; }
        public string UA_Info3 { get; set; }
        public string UA_Info4 { get; set; }
        public string UA_Info5 { get; set; }
        public string UA_Info6 { get; set; }
        public string UA_Info7 { get; set; }
        public string UA_Info8 { get; set; }
        public string UA_Info9 { get; set; }


        // **** RELATED REMITTANCE INFORMATION ****
        // {8250} Related Remittance Information
        public string RelRemit_ID { get; set; }
        public string RelRemit_Loc { get; set; }
        public string RelRemit_ElecAddr { get; set; }
        public string RelRemit_Name { get; set; }
        public string RelRemit_AddrType { get; set; }
        public string RelRemit_Dept { get; set; }
        public string RelRemit_SubDept { get; set; }
        public string RelRemit_StrName { get; set; }
        public string RelRemit_BldgNum { get; set; }
        public string RelRemit_PostCode { get; set; }
        public string RelRemit_TownName { get; set; }
        public string RelRemit_CountrySubDiv { get; set; }
        public string RelRemit_Country { get; set; }
        public string RelRemit_Addr1 { get; set; }
        public string RelRemit_Addr2 { get; set; }
        public string RelRemit_Addr3 { get; set; }
        public string RelRemit_Addr4 { get; set; }
        public string RelRemit_Addr5 { get; set; }
        public string RelRemit_Addr6 { get; set; }
        public string RelRemit_Addr7 { get; set; }


        // **** STRUCTURED REMITTANCE INFORMATION (ONCE) ****
        // {8300} Remittance Originator
        public string RemitOrig_Type { get; set; }
        public string RemitOrig_Code { get; set; }
        public string RemitOrig_Name { get; set; }
        public string RemitOrig_IDNum { get; set; }
        public string RemitOrig_IDNumIss { get; set; }
        public string RemitOrig_Birth { get; set; }
        public string RemitOrig_AddrType { get; set; }
        public string RemitOrig_Dept { get; set; }
        public string RemitOrig_SubDept { get; set; }
        public string RemitOrig_StreetName { get; set; }
        public string RemitOrig_BldgNum { get; set; }
        public string RemitOrig_PostCode { get; set; }
        public string RemitOrig_TownName { get; set; }
        public string RemitOrig_CountrySub { get; set; }
        public string RemitOrig_Country { get; set; }
        public string RemitOrig_Addr1 { get; set; }
        public string RemitOrig_Addr2 { get; set; }
        public string RemitOrig_Addr3 { get; set; }
        public string RemitOrig_Addr4 { get; set; }
        public string RemitOrig_Addr5 { get; set; }
        public string RemitOrig_Addr6 { get; set; }
        public string RemitOrig_Addr7 { get; set; }
        public string RemitOrig_CountryRes { get; set; }
        public string RemitOrig_ContactName { get; set; }
        public string RemitOrig_PhoneNum { get; set; }
        public string RemitOrig_MobileNum { get; set; }
        public string RemitOrig_FaxNum { get; set; }
        public string RemitOrig_ContactElec { get; set; }
        public string RemitOrig_ContactOther { get; set; }

        // {8350} Remittance Beneficiary
        public string RemitBnf_Name { get; set; }
        public string RemitBnf_Type { get; set; }
        public string RemitBnf_Code { get; set; }
        public string RemitBnf_IDNum { get; set; }
        public string RemitBnf_IDNumIss { get; set; }
        public string RemitBnf_Birth { get; set; }
        public string RemitBnf_AddrType { get; set; }
        public string RemitBnf_Dept { get; set; }
        public string RemitBnf_SubDept { get; set; }
        public string RemitBnf_StreetName { get; set; }
        public string RemitBnf_BldgNum { get; set; }
        public string RemitBnf_PostCode { get; set; }
        public string RemitBnf_TownName { get; set; }
        public string RemitBnf_CountrySub { get; set; }
        public string RemitBnf_Country { get; set; }
        public string RemitBnf_Addr1 { get; set; }
        public string RemitBnf_Addr2 { get; set; }
        public string RemitBnf_Addr3 { get; set; }
        public string RemitBnf_Addr4 { get; set; }
        public string RemitBnf_Addr5 { get; set; }
        public string RemitBnf_Addr6 { get; set; }
        public string RemitBnf_Addr7 { get; set; }
        public string RemitBnf_CountryRes { get; set; }


        // **** STRUCTURED REMITTANCE INFORMATION (REPEAT) ****
        // {8400} Primary Remittance Documentation Information
        public string PrimRemit_DocType { get; set; }
        public string PrimRemit_PropDocType { get; set; }
        public string PrimRemit_DocID { get; set; }
        public string PrimRemit_Issuer { get; set; }

        // {8450} Actual Amount Paid
        public string AmtPaid_CurrCode { get; set; }
        public string AmtPaid_Amount { get; set; }

        // {8500} Gross Amount of Remittance Document
        public string GrossAmtRemit_CurrCode { get; set; }
        public string GrossAmtRemit_Amount { get; set; }

        // {8550} Amount of Negotiated Discount
        public string AmtNegDisc_CurrCode { get; set; }
        public string AmtNegDisc_Amount { get; set; }

        // {8600} Adjustment Information
        public string AdjustInfo_RsnCode { get; set; }
        public string AdjustInfo_Indicator { get; set; }
        public string AdjustInfo_CurrCode { get; set; }
        public string AdjustInfo_Amount { get; set; }
        public string AdjustInfo_Info { get; set; }

        // {8650} Date of Remittance Document
        public string DateOfRemitDoc { get; set; }

        // {8700} Secondary Remittance Document Information
        public string SecRemit_Type { get; set; }
        public string SecRemit_PropDocType { get; set; }
        public string SecRemit_DocID { get; set; }
        public string SecRemit_Issuer { get; set; }

        // {8750} Remittance Free Text
        public string Remit_FreeText1 { get; set; }
        public string Remit_FreeText2 { get; set; }
        public string Remit_FreeText3 { get; set; }


        // **** SERVICE MESSAGE INFORMATION ****
        // {9000} Service Message Information
        public string SVCInfo_L1 { get; set; }
        public string SVCInfo_L2 { get; set; }
        public string SVCInfo_L3 { get; set; }
        public string SVCInfo_L4 { get; set; }
        public string SVCInfo_L5 { get; set; }
        public string SVCInfo_L6 { get; set; }
        public string SVCInfo_L7 { get; set; }
        public string SVCInfo_L8 { get; set; }
        public string SVCInfo_L9 { get; set; }
        public string SVCInfo_L10 { get; set; }
        public string SVCInfo_L11 { get; set; }
        public string SVCInfo_L12 { get; set; }


        // **** INFORMATION APPENDED BY FEDWIRE FUNDS SERVICE ****
        // {1100} Message Disposition
        public string MsgDisp_Version { get; set; }
        public string MsgDisp_ProdCode { get; set; }
        public string MsgDisp_DupCode { get; set; }
        public string MsgDisp_Status { get; set; }

        // {1110} Reciept Time Stamp
        public string RcptTimeStamp_Date { get; set; }
        public string RcptTimeStamp_Time { get; set; }
        public string Rcpt_AppID { get; set; }

        // {1120} Output Message Accountability Data (OMAD)
        public string OMAD_CycleDate { get; set; }
        public string OMAD_DestID { get; set; }
        public string OMAD_SeqNum { get; set; }
        public string OMAD_Date { get; set; }
        public string OMAD_Time { get; set; }
        public string OMAD_FRBID { get; set; }

        // {1130} Error
        public string Error_Category { get; set; }
        public string Error_Code { get; set; }
        public string Error_Desc { get; set; }



    }
}

