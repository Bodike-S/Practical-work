using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2
{
    class Employee
    {
        internal string name;
        private DateTime hiringDate;
        public Employee(string _name, DateTime _hiringDate)
        {
            name = _name;
            hiringDate = _hiringDate;
        }
        public int Experience()
        {
            return DateTime.Now.Year - hiringDate.Year;
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"{name} has {Experience()} years of experience");
        }
    }
}
