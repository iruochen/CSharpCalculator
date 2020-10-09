using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class NewAdd:Add, IStringUnion
    {
        private string _str1;
        private string _str2;

        public string Str1
        {
            get { return _str1; }
            set { _str1 = value; }
        }
        public string Str2
        {
            get { return _str2; }
            set { _str2 = value; }
        }

        public string StringUnion() {
            return Str1 + Str2;
        }
    }
}
