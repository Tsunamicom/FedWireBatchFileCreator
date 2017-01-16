using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace FedWire_Batch_File_Creator
{
    public class FedWireField : IFedWireField
    {
        private string _FieldValue;
        private string _tag;
        
        public string FieldValue{ get { return _FieldValue; } set { _FieldValue = value; } }

        public string Tag { get { return _tag; } }
        public string isValid { get { return isValid; } }

        public FedWireField(string tag)
        {
            _tag = tag;
        }
    }
}
