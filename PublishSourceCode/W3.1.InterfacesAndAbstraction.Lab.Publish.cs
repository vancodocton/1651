using System;

namespace W3._1.InterfacesAndAbstraction.Lab
{
    class Program
    {
        static void Main()
        {
            //Shapes.StartUp.Run();
            Cars.StartUp.Run();

            Console.ReadKey(true);
        }
    }
}
namespace Shapes
{
    public class StartUp
    {
        public static void Run()
        {
            var radius = int.Parse(Console.ReadLine());
            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());

            var circle = new Circle(radius);
            var rectangle = new Rectangle(width, height);

            circle.Draw();
            rectangle.Draw();
        }
    }
    public interface IDrawable
    {
        void Draw();
    }
    public class Circle : IDrawable
    {
        public int Radius { get; protected set; }

        public Circle(int radius)
        {
            Radius = radius;
        }

        public void Draw()
        {
            double rIn = Radius - 0.4;
            double rOut = Radius + 0.4;

            for (double y = Radius; y >= -Radius; y--)
            {
                for (double x = -Radius; x <= Radius; x += 0.5)
                {
                    double value = x * x + y * y;

                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
    public class Rectangle : IDrawable
    {
        public int Width { get; private set; }

        public int Height { get; private set; }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public void Draw()
        {
            DrawLine(Width, '*', '*');
            for (int i = 1; i < Height - 1; i++)
            {
                DrawLine(Width, '*', ' ');
            }
            DrawLine(Width, '*', '*');
        }

        private void DrawLine(int length, char terminal, char mid)
        {
            Console.Write(terminal);
            for (int i = 1; i < length - 1; i++)
            {
                Console.Write(mid);
            }
            Console.WriteLine(terminal);
        }
    }
}
namespace Cars
{
    public class StartUp
    {
        public static void Run()
        {
            ICar seat = new Seat("Leon", "Grey");
            ICar tesla = new Tesla("Model 3", "Red", 2);

            Console.WriteLine(seat);
            Console.WriteLine(tesla);
        }
    }
    public interface ICar
    {
        string Model { get; }
        string Color { get; }
        string Start();
        string Stop();
    }
    public interface IElectricCar
    {
        int Battery { get; }
    }
    public class Seat : ICar
    {

        public string Model { get; private set; }
        public string Color { get; private set; }

        public Seat(string model, string color)
        {
            Model = model;
            Color = color;
        }
        public string Start() => "Engine start";
        public string Stop() => "Breaaak!";

        public override string ToString()
        {
            return $"{Color} {base.GetType().Name} {Model}\n" + Start() + "\n" + Stop();
        }
    }
    public class Tesla : ICar, IElectricCar
    {
        public string Model { get; private set; }
        public string Color { get; private set; }
        public int Battery { get; private set; }

        public Tesla(string model, string color, int battery)
        {
            Model = model;
            Color = color;
            Battery = battery;
        }
        public string Start() => "Engine start";
        public string Stop() => "Breaaak!";
        public override string ToString()
        {
            return $"{Color} {base.GetType().Name} {Model} with {Battery} Batteries\n" + Start() + "\n" + Stop();
        }
    }

}
