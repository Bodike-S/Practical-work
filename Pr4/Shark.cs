using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr4
{
    class Shark:IAnimal, ISwimmable
    {
        public int LifeDuration { get; set; }

        public Shark()
        {
            LifeDuration += IAnimal.LifeDuration;
        }
        public void ShowInfo() => IAnimal.ShowInfo(this);
        public void Swim() => ISwimmable.Swim();
    }
}
