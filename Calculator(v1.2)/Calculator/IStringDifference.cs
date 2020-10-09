using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    interface IStringDifference
    {
        string Str1
        {
            get;
            set;
        }
        string Str2
        {
            get;
            set;
        }
        string StringDifference();
    }
}
