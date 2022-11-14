using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2
{
    class Tester:Employee
    {
        private bool isAuthomation;
        public Tester(string name, DateTime hiringDate, bool _isAuthomation):base(name, hiringDate)
        {
            isAuthomation = _isAuthomation;
        }
    }
}
