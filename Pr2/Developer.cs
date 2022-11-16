using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2
{
    class Developer : Employee
    {
        private string programmingLanguag;
        public Developer(string name, DateTime hiringDate, string _programmingLanguag) : base(name, hiringDate)
        {
            programmingLanguag = _programmingLanguag;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"{name} has {Experience()} years of experience {name} is {programmingLanguag} programmer");
        }
    }
}
