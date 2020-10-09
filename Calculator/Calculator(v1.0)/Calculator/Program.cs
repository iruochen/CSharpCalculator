using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Calculation> list = new List<Calculation>();
            Calculation c = new Calculation();
            c.Operator = "+";
            c.Number1 = 1;
            c.Number2 = 2;
            list.Add(c);

            Calculation c2 = new Calculation();
            c2.Operator = "/";
            c2.Number1 = 1;
            c2.Number2 = 0;
            list.Add(c2);
            foreach (Calculation i in list) {
                Console.WriteLine("{0} 与 {1}{2}", i.Number1, i.Number2, i.Number1.Equals(i.Number2) == true ? "相等" : "不相等");
                string result = i.f(i.Operator);
                Console.Write("{0} {1} {2} = ", i.Number1, i.Operator, i.Number2);
                Console.WriteLine(result);
            }     

        }
    }
}
