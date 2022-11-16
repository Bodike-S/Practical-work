using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2
{
    class Lory:Car
    {
        private double loadCapacity;
        public Lory(string mark, int prodYear, double _loadCapacity) : base(mark, prodYear)
        {
            loadCapacity = _loadCapacity;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"The load capacity is {loadCapacity}\n");
        }
    }
}
