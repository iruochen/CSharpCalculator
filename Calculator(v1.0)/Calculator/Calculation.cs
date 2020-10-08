using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class Calculation
    {
        private string _operator;
        private double _number1, _number2;

        
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
          
        public string Operator
        {
            get { return _operator; }
            set { _operator = value; }
        }
          
        public string f(string str) {
            switch (str) {
                case "+": return Convert.ToString(_number1 + _number2);
                case "-": return Convert.ToString(_number1 - _number2);
                case "*": return Convert.ToString(_number1 * _number2);
                case "/": // if (_number2 == 0) throw new Exception("除数不能为0");
                          // else return Convert.ToString(_number1 / Number2); 
                          try { return Convert.ToString(_number1 / _number2); }
                          catch (Exception e) { Console.WriteLine("除数不能为0"); }
                          break;
                default:
                    break;
            }
            return "请检查您的输入";
        }

        public override bool Equals(object obj)
        {
            if (_number1 == _number2) return true;
            else return false;
        }
    }
}
