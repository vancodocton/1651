using System;

namespace L2ClassMethod
{
    public class Person
    {
        protected int age;
        protected string name;

        public int Age { get => age; }
        public string Name { get => name; }

        public Person()
        {
        }
        public Person(int age, string name)
        {
            this.age = age;
            this.name = name;
        }
        public void DisplayPerson()
        {
            Console.WriteLine($"Name:\t{name}");
            Console.WriteLine($"Age: \t{age}");
        }
        public virtual void Input()
        {
            Console.Write("Please input name: ");
            this.name = Console.ReadLine();
            Console.Write("Please input age: ");
            this.age = int.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return $"Name: {name}, Age: {age}";
        }
    }
    public class Student : Person
    {
        protected double gpa;
        public double Gpa { get => gpa; }

        public Student(string name, int age, double gpa)
        {
            this.age = age;
            this.name = name;
            this.gpa = gpa;
        }
        public Student()
        {
        }
        public void DisplayInformation()
        {
            DisplayPerson();
            Console.WriteLine($"GPA: \t{gpa}");
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Please input GPA: ");
            gpa = double.Parse(Console.ReadLine());
        }
        public override string ToString()
        {
            return base.ToString() + $", GPA: {gpa}";
        }
    }
    public class Fraction
    {
        public int Numerator { get; private set; }
        public int Denominator { get; private set; }
        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new DivideByZeroException();

            int gcd = GCD(numerator, denominator);
            Numerator = numerator / gcd;
            Denominator = denominator / gcd;

            if (Denominator < 0)
            {
                Denominator *= -1;
                Numerator *= -1;
            }
        }
        protected static int GCD(int a, int b)
        {
            if (Math.Abs(a) < Math.Abs(b))
                Swap(ref a, ref b);

            int tmp;
            while (b != 0)
            {
                tmp = b;
                b = a % b;
                a = tmp;
            }
            return a;
        }
        protected static void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
        public override string ToString()
        {
            return $"{Numerator} / {Denominator}\n";
        }
        public decimal ToDecimal()
        {
            return (decimal)Numerator / Denominator;
        }
    }

    public class MathFranction
    {
        public static Fraction Add(Fraction a, Fraction b)
        {
            int numerator = a.Numerator * b.Denominator + b.Numerator * a.Denominator;
            int denominator = a.Denominator * b.Denominator;

            return new Fraction(numerator, denominator);
        }

        public static Fraction Subtract(Fraction a, Fraction b)
        {
            int numerator = a.Numerator * b.Denominator - b.Numerator * a.Denominator;
            int denominator = a.Denominator * b.Denominator;

            return new Fraction(numerator, denominator);
        }

        public static Fraction Multiply(Fraction a, Fraction b)
        {
            int numerator = a.Numerator * b.Numerator;
            int denominator = a.Denominator * b.Denominator;

            return new Fraction(numerator, denominator);
        }
        public static Fraction Divide(Fraction a, Fraction b)
        {
            int numerator = a.Numerator * b.Denominator;
            int denominator = a.Denominator * b.Numerator;

            return new Fraction(numerator, denominator);
        }
    }
    class Program
    {
    //     static void Main()
    //     {
    //         int a = 10;
    //         int b = -20;

    //         int c = -4;
    //         int d = -6;

    //         var fraction1 = new Fraction(a, b);
    //         var fraction2 = new Fraction(c, d);

    //         Console.WriteLine(fraction1.ToString());
    //         Console.WriteLine(fraction2);

    //         Console.WriteLine(MathFranction.Divide(fraction1, fraction2).ToDecimal());
    //         Console.ReadKey(true);
    //     }
    }
}
