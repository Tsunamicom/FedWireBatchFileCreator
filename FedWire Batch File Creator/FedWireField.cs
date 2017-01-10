using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FedWire_Batch_File_Creator
{
    public class FedWireField
    {
        private string _tag;
        private bool _mandatory;
        private bool _isAllowed = true;
        private bool _isActive = false;
        private readonly IDictionary<string, string> _tagData = new Dictionary<string, string>();
        private string _simpleFieldData;
        
        public string Tag { get { return _tag; } }
        public bool isMandatory { get { return _mandatory; } set { _mandatory = value; } }
        public bool isAllowed { get { return _isAllowed; } set { isAllowed = value; } }
        public bool isActive { get { return _isActive; } set { _isActive = value; } }
        public string FieldValue { get { return _simpleFieldData; } set { _simpleFieldData = value; } }

        public string this[string key]
        {
            get { return _tagData[key]; }
            set
            {
                if (_isActive == false)
                {
                    _isActive = true;
                }
                _tagData[key] = value;
            }
        }

        public FedWireField(string tag, bool isMandatory = false)
        {
            _tag = tag;
            _mandatory = isMandatory;
        }

        public override string ToString() // Debug String
        {
            return "{"+Tag+"}"+"\n"+string.Join("\n", _tagData)+"\n";
        }



    }
}
