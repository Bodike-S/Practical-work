using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr1
{
    public abstract class CloseableResource
    {
        public void Close()
        {
            Console.WriteLine("some closing actions");//some closing actions
        }

        //some code
    }
}
