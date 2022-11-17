using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr3
{
    public static class ExtensionMethods
    {
        public static int CountWords(this string s)
        {
            return s.Split(" .?!-;,:".ToCharArray(),
                StringSplitOptions.RemoveEmptyEntries).Length;
        }   
    }
    public delegate double CalcDelegate(double a, double b, char SymOperation);
    class Program
    {
        static List<T> ListWithPositive<T>(List<T> array, Predicate<T> isPositive)
        {
            return array.FindAll(isPositive);
        }
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
            List<int> arr  = new List<int>();
            var rand = new Random();

            for (int i = 0; i < 10; ++i)
                arr.Add(rand.Next(-10, 10));
            arr = ListWithPositive<int>(arr, delegate (int a)
            {
                return a > 0 & a <= 10;
            });
            Console.Write('|');
            foreach (var item in arr)
            {
                Console.Write($"| {item} |");
            }
            Console.Write('|');
        }
    }
}
