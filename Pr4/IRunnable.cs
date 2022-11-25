using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr4
{
    public interface IRunnable
    {
        static int MaxSpeed { get { return 0; } }
        static void Run(IRunnable runnable)=> Console.WriteLine($"I can run up to {runnable.GetType().GetProperty("MaxSpeed").GetValue(runnable)} kilometers per hour!");
    }
}
