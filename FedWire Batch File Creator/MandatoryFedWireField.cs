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

        public MandatoryFedWireField(string tag, int maxLength=9999) : base(tag, maxLength){}
    }
}
