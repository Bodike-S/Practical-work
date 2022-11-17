using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr3
{
    public delegate double CalcDelegate(double a, double b, char SymOperation);
    class Program
    {
        static double Calc(double a, double b, char SymOperation)
        {
            double res = 0.0;
            switch (SymOperation)
            {
                case '+':
                    res = a + b; break;
                case '-':
                    res = a - b; break;
                case '*':
                    res = a * b; break;
                case '/':
                    if (b == 0)
                        res = 0.0;
                    else
                        res = a / b; break;
                default:
                    Console.WriteLine("Wrong select operation"); break;
            };
            return res;
        }
        static void Main(string[] args)
        {
            CalcDelegate funcCalc =Calc;
            CalcProgram calc = new CalcProgram();
            //calc.GetQuot(out funcCalc);
            funcCalc += CalcProgram.Calc;
        }
    }
}
