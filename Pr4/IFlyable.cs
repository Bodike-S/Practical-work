using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr4_T1
{
    public interface IFlyable
    {
        static int MaxHeight { get { return 0; } }
        static void Fly(IFlyable flyable) => Console.WriteLine($"I can fly at {flyable.GetType().GetProperty("MaxHeight").GetValue(flyable)} meters height!");
    }
}
