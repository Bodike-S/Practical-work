using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr4_T1
{
    class Cat:IAnimal,IRunnable
    {
        public int LifeDuration { get; set; }
        public int MaxSpeed { get; set; }
        public Cat()
        {
            this.LifeDuration +=  IAnimal.LifeDuration;
            this.MaxSpeed += IRunnable.MaxSpeed;
        }
        public void Voice() => Console.WriteLine("Meow!");
        public void ShowInfo() => IAnimal.ShowInfo(this);
        public void Run() => IRunnable.Run(this);
    }
}
