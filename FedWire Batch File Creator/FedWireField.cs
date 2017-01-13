using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FedWire_Batch_File_Creator
{
    public class FedWireField
    {
        private string _FieldValue;
        private string _tag;
        private bool _isAllowed = true;
        private bool _isActive = false;
        private int _maxLength = 9999;
        
        public bool isAllowed { get { return _isAllowed; } set { isAllowed = value; } }
        public bool isActive { get { return _isActive; } set { _isActive = value; } }
        public string FieldValue { get { return _FieldValue; } set { if (value.Length <= _maxLength) { _FieldValue = value; } } }
        public string Tag { get { return _tag; } }

        public FedWireField(string tag, int maxLength=9999)
        {
            _maxLength = maxLength;
            _tag = tag;
        }
    }
}
