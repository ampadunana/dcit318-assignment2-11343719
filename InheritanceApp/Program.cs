using System;

namespace InheritanceApp
{
    class Animal
    {
        public virtual void MakeSound() => Console.WriteLine("Some generic sound");
    }

    class Dog : Animal
    {
        public override void MakeSound() => Console.WriteLine("Bark");
    }

    class Cat : Animal
    {
        public override void MakeSound() => Console.WriteLine("Meow");
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Choose an animal (dog / cat): ");
            string? choice = Console.ReadLine()?.Trim().ToLower();

            Animal a = choice switch
            {
                "dog" => new Dog(),
                "cat" => new Cat(),
            };

            a.MakeSound();
            Console.WriteLine("Press any key to exit…");
            Console.ReadKey();
        }
    }
}
