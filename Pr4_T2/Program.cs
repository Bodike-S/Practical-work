using System;

namespace Pr4_T2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.Name = "Garfild";
            Dog dog = new Dog();
            dog.Name = "Oggi";
            Console.WriteLine($"{cat.Name} - Cat");
            cat.Feed();
            Console.WriteLine($"{dog.Name} - Dog");
            dog.Feed();
        }
    }
}
//F:\C#\Practical-work\Pr4\Pr4_T1.csproj