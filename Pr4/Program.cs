using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr4
{
    class Program
    {
        static void Main(string[] args)
        {

            //чисто тест на життєздатність
            Cat cat = new Cat();
            cat.MaxSpeed = 20;
            cat.LifeDuration = 30;
            cat.Voice();
            cat.ShowInfo();
            Eagle eagle = new Eagle();
            eagle.LifeDuration = 10;
            eagle.MaxHeight = 2000;
            eagle.ShowInfo();
            eagle.Fly();
            Shark shark = new Shark();
            shark.LifeDuration = 20;
            shark.ShowInfo();
            shark.Swim();
        }
    }
}
