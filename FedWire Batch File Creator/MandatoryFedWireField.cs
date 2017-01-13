using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FedWire_Batch_File_Creator
{
    public class MandatoryFedWireField : FedWireField
    {
        public string SenderSuppliedInformation { get; set; }
        public string TypeSubType { get; set; }
        public string IMAD { get; set; }
        public string Amount { get; set; }
        public string SenderDI { get; set; }
        public string RecieverDI { get; set; }
        public string BusinessFunctionCode { get; set; }

        public MandatoryFedWireField(string tag, int maxLength = 9999) : base(tag, maxLength)
        {
            assignFieldValue();
        }
        
        public void assignFieldValue()
        {
            switch (base.Tag)
            {
                case ("1500"):
                    {
                        base.FieldValue = SenderSuppliedInformation+"";
                        break;
                    }
                case ("1510"):
                    {
                        base.FieldValue = TypeSubType+"";
                        break;
                    }
                case ("1520"):
                    {
                        base.FieldValue = IMAD+"";
                        break;
                    }
                case ("2000"):
                    {
                        base.FieldValue = Amount+"";
                        break;
                    }
                case ("3100"):
                    {
                        base.FieldValue = SenderDI+"";
                        break;
                    }
                case ("3400"):
                    {
                        base.FieldValue = RecieverDI+"";
                        break;
                    }
                case ("3600"):
                    {
                        base.FieldValue = BusinessFunctionCode+"";
                        break;
                    }
                default:
                    {
                        base.FieldValue = "INVALID";
                        break;
                    }
                    
            }
        }
    }
}
