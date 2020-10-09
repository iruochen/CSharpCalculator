using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class Add:Calculation
    {
        /// <summary>
        /// 加法运算
        /// </summary>
        /// <returns>两个数的和</returns>
        public override double result()
        {
            return Number1 + Number2;
        }
    }
}
