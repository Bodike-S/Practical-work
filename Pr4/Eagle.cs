using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr4_T1
{
    class Eagle:IAnimal, IFlyable
    {
        public int LifeDuration { get; set; }
        public int MaxHeight { get; set; }
        public Eagle()
        {
            LifeDuration += IAnimal.LifeDuration;
            MaxHeight += IFlyable.MaxHeight;
        }
        public void ShowInfo() => IAnimal.ShowInfo(this);
        public void Fly() => IFlyable.Fly(this);
    }
}
