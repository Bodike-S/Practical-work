using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr4
{
    public interface IAnimal
    {
        public static int LifeDuration { get { return 0; } }
        public static void Voice() => Console.WriteLine("No voice!");
        public static void ShowInfo(IAnimal animal) => Console.WriteLine($"I am a {animal.GetType().Name} and I live approximately {animal.GetType().GetProperty("LifeDuration").GetValue(animal)} years.");
    }
}
