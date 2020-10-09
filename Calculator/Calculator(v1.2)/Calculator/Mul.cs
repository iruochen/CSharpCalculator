using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class Mul:Calculation
    {
        /// <summary>
        /// 乘法运算
        /// </summary>
        /// <returns>两个数的乘积</returns>
        public override double result()
        {
            return Number1 * Number2;
        }
    }
}
