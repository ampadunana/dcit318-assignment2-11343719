using System;

namespace InterfaceApp
{
    interface IMovable { void Move(); }

    class Car : IMovable
    {
        public void Move() => Console.WriteLine("Car is moving");
    }

    class Bicycle : IMovable
    {
        public void Move() => Console.WriteLine("Bicycle is moving");
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Choose a vehicle (car / bicycle): ");
            string choice = (Console.ReadLine() ?? "").Trim().ToLower();

            IMovable mover;
            switch (choice)
            {
                case "car":
                    mover = new Car();
                    break;
                case "bicycle":
                    mover = new Bicycle();
                    break;
                default:
                    Console.WriteLine("Unknown vehicle");
                    mover = new Bicycle();
                    break;
            }

            mover.Move();
            Console.WriteLine("Press any key to exit…");
            Console.ReadKey();
        }
    }
}
