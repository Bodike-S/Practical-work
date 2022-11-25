using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr4_T2
{
    class Dog:IAnimal
    {
        public string Name { get; set; }
        public void Voice() => Console.WriteLine("Woof");
        public void Feed() => Console.WriteLine("I eat meat");
    }
}
