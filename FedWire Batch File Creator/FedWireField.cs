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
        private string _regex;
        private bool _isValid = false;

        
        public string FieldValue
        {
            get
            {
                return _FieldValue;
            }
            set
            {
                if (Regex.IsMatch(value, _regex))
                {
                    _FieldValue = value;
                    _isValid = true;
                }
                else
                {
                    _FieldValue = "";
                    _isValid = false;
                }
            }
        }
        public string Tag { get { return _tag; } }
        public string isValid { get; }

        public FedWireField(string tag, string regex="")
        {
            _tag = tag;
            _regex = regex;
        }
    }
}
