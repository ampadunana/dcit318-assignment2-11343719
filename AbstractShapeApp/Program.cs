using System;

namespace AbstractShapeApp
{
    abstract class Shape
    {
        public abstract double GetArea();
    }

    class Circle : Shape
    {
        public double Radius { get; }
        public Circle(double r) => Radius = r;

        public override double GetArea() => Math.PI * Radius * Radius;
    }

    class Rectangle : Shape
    {
        public double Width { get; }
        public double Height { get; }
        public Rectangle(double w, double h)
        {
            Width = w;
            Height = h;
        }

        public override double GetArea() => Width * Height;
    }

    class Program
    {

        static double ReadDouble(string prompt)
        {
            double v;                                
            Console.Write(prompt);
            while (!double.TryParse(Console.ReadLine(), out v) || v <= 0)
                Console.Write("  • Please enter a positive number: ");
            return v;
        }

        static void Main()
        {
            Console.Write("Choose a shape (circle / rectangle): ");
            string choice = (Console.ReadLine() ?? "").Trim().ToLower();

            Shape shape;
            switch (choice)
            {
                case "circle":
                    shape = new Circle(ReadDouble("Enter radius: "));
                    break;

                case "rectangle":
                    shape = new Rectangle(
                        ReadDouble("Enter width: "),
                        ReadDouble("Enter height: "));
                    break;

                default:
                    Console.WriteLine("Unknown shape");
                    shape = new Rectangle(1, 1);
                    break;
            }

            Console.WriteLine($"Area = {shape.GetArea():F2}");
            Console.WriteLine("Press any key to exit…");
            Console.ReadKey();
        }
    }
}