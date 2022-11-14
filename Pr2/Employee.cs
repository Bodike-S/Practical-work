using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2
{
    /*
    Class Employee should contain public void method ShowInfo() that prints the such string:
    "<name> has <Experience> years of experience".
    Class Developer should contain public void method ShowInfo() that prints the such string:
    "<name> has <Experience> years of experience
    <name> is <programmingLanguage> programmer".
    Please, pay attention that the first line as the same as for appropriate Employee’s method.
    Class Tester should contain public void method ShowInfo() that prints the such string
    “<name> is authomated tester and has <Experience> year(s) of experience”
    If isAuthomated field is true
    Or
    “<name> is manual tester and has <Experience> year(s) of experience”
    If isAuthomated field is false.*/
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
    }
}
