using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class BitWise:Calculation
    {
        public override double result()
        {
            return (int)Number1 & (int)Number2;
        }
    }
}
