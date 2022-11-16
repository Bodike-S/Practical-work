using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2
{
    class SportCar:Car
    {
        private int maxSpeed;
        public SportCar(string mark, int prodYear, int _maxSpeed):base(mark, prodYear)
        {
            maxSpeed = _maxSpeed;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Maximum speed is {maxSpeed }\n");
        }
    }
}
