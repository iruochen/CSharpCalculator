using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class Sub:Calculation
    {
        /// <summary>
        /// 减法运算
        /// </summary>
        /// <returns>两个数的差</returns>
        public override double result()
        {
            return Number1 - Number2;
        }
    }
}
