using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class Surplus:Calculation
    {
        public override double result()
        {
            double result = 0;
            try {
                result = Number1 % Number2;
            }
            catch (Exception e) {
                e.ToString();
            }
            return result;
            
        }
    }
}
