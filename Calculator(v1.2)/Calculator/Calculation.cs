using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    abstract class Calculation
    {
        private double _number1;
        private double _number2;

        public double Number1
        {
            get { return _number1; }
            set { _number1 = value; }
        }
        public double Number2
        {
            get { return _number2; }
            set { _number2 = value; }
        }
        public abstract double result();
    }
}
