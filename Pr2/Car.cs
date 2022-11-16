using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2
{
    public abstract class Car
    {
        internal string mark;
        internal int prodYear;

        public Car(string _mark, int _prodYear)
        {
            mark = _mark;
            prodYear = _prodYear;
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Mark : {mark},\nProducted in {prodYear}\n");
        }
    }
}
