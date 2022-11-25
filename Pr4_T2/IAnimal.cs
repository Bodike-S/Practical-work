using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr4_T2
{
    public interface IAnimal
    {
        public string Name { get; set; }
        public void Voice();
        public void Feed();
    }
}
