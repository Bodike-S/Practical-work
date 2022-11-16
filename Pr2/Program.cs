using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2
{
    class Program
    {
        static void Main(string[] args)
        {
            Science science1 = new Mathematics();
            Science science2 = new Physics();
            Science science3 = new Science();

            science1.Awards();
            science2.Awards();
            science3.Awards();
        }
    }
}
