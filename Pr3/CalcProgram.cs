using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr3
{
    class CalcProgram
    {
        public static double Calc(double a, double b, char SymOperation)
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
        public void GetQuot(out CalcDelegate dlg)
        {
            dlg = Calc;
        }
    }
}
