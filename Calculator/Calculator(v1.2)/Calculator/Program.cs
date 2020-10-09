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
            /*
            Console.WriteLine("请依次输入运算的两个数");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            List<Calculation> calculations = new List<Calculation>{
                new Add(),
                new Sub(),
                new Mul(),
                new Div(),
                new Surplus(),
                new BitWise()
            };
            foreach (var calculation in calculations) {
                calculation.Number1 = num1;
                calculation.Number2 = num2;
                Console.WriteLine(calculation.result().ToString());
            }
            */

            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            IStringUnion n = new NewAdd();
            n.Str1 = str1;
            n.Str2 = str2;
            Console.WriteLine(n.StringUnion());
            IStringDifference i = new NewSub();
            i.Str1 = str1;
            i.Str2 = str2;
            Console.WriteLine(i.StringDifference());
        }
    }
}
