using System;
using PlayersAndMonsters;
using Persons;
using Zoo;
using NeedForSpeed;
using System.Collections.Generic;
using Animals;
namespace Persons
{
    public class Person
    {
        protected int age;
        protected string name;

        public int Age { get => age; }
        public string Name { get => name; }

        public Person(string name, int age)
        {
            if (age < 0)
                throw new AgeIsNegativeEception();
            else
            {
                this.age = age;
                this.name = name;
            }
        }
        public Person()
        {
            age = 0;
            name = "";
        }
        protected class AgeIsNegativeEception : Exception
        {
            public override string Message => "Age is negative";
        }
        public override string ToString()
        {
            return $"Name: {name}, Age: {age}";
        }
    }
    public class Child : Person
    {
        public Child(string name, int age) : base(name, age)
        {
            if (age >= 15)
                throw new InvalidChildAge();
        }
        public Child() : base()
        {
        }
        protected class InvalidChildAge : Exception
        {
            public override string Message => "Age of child is more than 15";
        }
    }
}
namespace Zoo
{
    public class Animal
    {
        protected string name;
        public string Name { get => name; set => name = value; }

        public Animal()
        {
            this.name = "";
        }
        public Animal(string name)
        {
            this.name = name;
        }
    }
    public class Mammal : Animal
    {
        public Mammal() : base() { }
        public Mammal(string name) : base(name) { }
    }
    public class Reptile : Animal
    {
        public Reptile() : base() { }
        public Reptile(string name) : base(name) { }
    }
    public class Lizard : Reptile
    {
        public Lizard() : base() { }
        public Lizard(string name) : base(name) { }
    }
    public class Snake : Reptile
    {
        public Snake() : base() { }
        public Snake(string name) : base(name) { }
    }
    public class Gorilla : Mammal
    {
        public Gorilla() : base() { }
        public Gorilla(string name) : base(name) { }
    }
    public class Bear : Mammal
    {
        public Bear() : base() { }
        public Bear(string name) : base(name) { }
    }
}

namespace PlayersAndMonsters
{
    public static class StartUp
    {
        public static void Run()
        {

        }
    }
    public class Hero
    {
        protected string username;
        protected int level;

        public string Username { get => username; }
        public int Level { get => level; }
        public Hero()
        {
            username = "";
            level = 0;
        }
        public Hero(string username, int level)
        {
            this.username = username;
            this.level = level;
        }
        public override string ToString()
        {
            return $"Type: {this.GetType().Name}, Username: {this.username}, Level: {this.level}";
        }
    }
    public class Elf : Hero
    {
        public Elf() : base() { }
        public Elf(string username, int level) : base(username, level) { }
    }
    public class MuseElf : Elf
    {
        public MuseElf() : base() { }
        public MuseElf(string username, int level) : base(username, level) { }
    }
    public class Wizzard : Hero
    {
        public Wizzard() : base() { }
        public Wizzard(string username, int level) : base(username, level) { }
    }
    public class DarkWizzard : Wizzard
    {
        public DarkWizzard() : base() { }
        public DarkWizzard(string username, int level) : base(username, level) { }
    }
    public class SoulWizzard : DarkWizzard
    {
        public SoulWizzard() : base() { }
        public SoulWizzard(string username, int level) : base(username, level) { }
    }
    public class Knight : Hero
    {
        public Knight() : base() { }
        public Knight(string username, int level) : base(username, level) { }
    }
    public class DarkKnight : Knight
    {
        public DarkKnight() : base() { }
        public DarkKnight(string username, int level) : base(username, level) { }
    }
    public class BlazeKnight : Knight
    {
        public BlazeKnight() : base() { }
        public BlazeKnight(string username, int level) : base(username, level) { }
    }
}

namespace NeedForSpeed
{
    public class Vehicle
    {
        protected int horsePower;
        protected double fuel;
        protected double defaultFuelConsumption = 1.25;

        protected double fuelConsumption;
        public int HorsePower { get => horsePower; }
        public double Fuel { get => fuel; protected set { fuel = value; } }
        public double DefaultFuelConsumption { get => defaultFuelConsumption; }
        virtual public double FuelConsumption { get => fuelConsumption; private set { fuelConsumption = value; } }
        public Vehicle(int horsePower, double fuel)
        {
            this.horsePower = horsePower;
            this.fuel = fuel;
            this.fuelConsumption = 0;
        }
        virtual public void Drive(double kms)
        {
            double fuelUsed = defaultFuelConsumption * kms;
            fuelConsumption += fuelUsed;
            fuel -= fuelUsed;
        }
    }
    public class Motocycle : Vehicle
    {
        public Motocycle(int horsePower, double fuel) : base(horsePower, fuel) { }
    }
    public class RaceMotocycle : Motocycle
    {
        public RaceMotocycle(int horsePower, double fuel) : base(horsePower, fuel)
        {
            this.defaultFuelConsumption = 8;
        }
    }
    public class CrossMotocycle : Motocycle
    {
        public CrossMotocycle(int horsePower, double fuel) : base(horsePower, fuel) { }
    }
    public class Car : Vehicle
    {
        public Car(int horsePower, double fuel) : base(horsePower, fuel)
        {
            this.defaultFuelConsumption = 3;
        }
    }
    public class FamilyCar : Car
    {
        public FamilyCar(int horsePower, double fuel) : base(horsePower, fuel) { }
    }
    public class SportCar : Car
    {
        public SportCar(int horsePower, double fuel) : base(horsePower, fuel)
        {
            this.defaultFuelConsumption = 8;
        }
    }
}

namespace Restaurant
{
    public class Product
    {
        private string name;
        private decimal price;

        public Product(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        public string Name { get => name; set => name = value; }
        public decimal Price { get => price; set => price = value; }
    }
    public class Food : Product
    {
        private double grams;

        public Food(string name, decimal price, double grams) : base(name, price)
        {
            this.grams = grams;
        }
        public double Grams { get => grams; set => grams = value; }
    }
    public class Beverage : Product
    {
        private double milliliters;

        public Beverage(string name, decimal price, double milliliters) : base(name, price)
        {
            this.milliliters = milliliters;
        }
        public double Milliliters { get => milliliters; set => milliliters = value; }
    }
    public class HotBeverage : Beverage
    {
        public HotBeverage(string name, decimal price, double milliliters) : base(name, price, milliliters) { }
    }
    public class ColdBeverage : Beverage
    {
        public ColdBeverage(string name, decimal price, double milliliters) : base(name, price, milliliters) { }
    }
    public class MainDish : Food
    {
        public MainDish(string name, decimal price, double grams) : base(name, price, grams) { }
    }
    public class Fish : MainDish
    {
        public Fish(string name, decimal price) : base(name, price, 22) { }
    }
    public class Dessert : Food
    {
        private double calories;
        public Dessert(string name, decimal price, double grams, double calories) : base(name, price, grams)
        {
            this.calories = calories;
        }
        public double Calories { get => calories; set => calories = value; }
    }
    public class Cake : Dessert
    {
        public Cake(string name) : base(name, 5, 250, 1000) { }
    }
    public class Starter : Food
    {
        public Starter(string name, decimal price, double grams) : base(name, price, grams) { }
    }
    public class Soup : Starter
    {
        public Soup(string name, decimal price, double grams) : base(name, price, grams) { }
    }
    public class Coffee : HotBeverage
    {
        private double coffeeMilliliters;
        private decimal coffeePrice;
        private double caffein;

        public Coffee(string name, decimal price, double milliliters, double caffein) : base(name, price, milliliters)
        {
            coffeeMilliliters = 50;
            coffeePrice = 3.50M;
            this.caffein = caffein;
        }

        public double CoffeeMilliliters { get => coffeeMilliliters; set => coffeeMilliliters = value; }
        public decimal CoffeePrice { get => coffeePrice; set => coffeePrice = value; }
        public double Caffein { get => caffein; set => caffein = value; }
    }
    public class Tea : HotBeverage
    {
        public Tea(string name, decimal price, double milliliters) : base(name, price, milliliters) { }
    }
}
namespace Animals
{
    public class Animal
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            if (String.IsNullOrEmpty(name))
                throw new ArgumentException("Invalid Input!");
            if (age < 0)
                throw new ArgumentException("Invalid Input!");
            if (gender != "Male" && gender != "Female")
                throw new ArgumentException("Invalid Input!");
            this.name = name;
            this.age = age;
            this.gender = gender;
        }
        public override string ToString()
        {
            var builder = new System.Text.StringBuilder();
            builder.AppendLine(this.GetType().Name);
            builder.AppendLine($"{this.name} {this.age} {this.gender}");
            builder.Append(ProduceSound());
            return builder.ToString();
        }
        protected virtual string ProduceSound() => null;

        public string Name { get => name; protected set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Gender { get => gender; set => gender = value; }
    }
    public class Dog : Animal
    {
        public Dog(string name, int age, string gender) : base(name, age, gender) { }
        protected override string ProduceSound() => "Woof!";
    }
    public class Frog : Animal
    {
        public Frog(string name, int age, string gender) : base(name, age, gender) { }
        protected override string ProduceSound() => "Ribbit";

    }
    public class Cat : Animal
    {
        public Cat(string name, int age, string gender) : base(name, age, gender) { }
        protected override string ProduceSound() => "Meow meow";
    }
    public class Kitten : Cat
    {
        public Kitten(string name, int age) : base(name, age, "Female") { }
        protected override string ProduceSound() => "Meow";

    }
    public class TomCat : Cat
    {
        public TomCat(string name, int age) : base(name, age, "Male") { }
        protected override string ProduceSound() => "MEOW";

    }
    public class StartUp
    {
        public void Run()
        {
            var animals = new List<Animal>();

            do
            {
                string animalType = Console.ReadLine();
                if (animalType == "Beast!")
                    break;
                string[] cmd = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    var animal = new Animal(cmd[0], int.Parse(cmd[1]), cmd[2]);
                    switch (animalType)
                    {
                        case "Dog":
                            animals.Add(new Dog(animal.Name, animal.Age, animal.Gender));
                            break;
                        case "Frog":
                            animals.Add(new Frog(animal.Name, animal.Age, animal.Gender));
                            break;
                        case "Cat":
                            animals.Add(new Cat(animal.Name, animal.Age, animal.Gender));
                            break;
                        case "Kitten":
                            animals.Add(new Kitten(animal.Name, animal.Age));
                            break;
                        case "TomCat":
                            animals.Add(new TomCat(animal.Name, animal.Age));
                            break;
                        default:
                            throw new ArgumentException();
                    }
                }
                catch (ArgumentException)
                {
                    animals.Add(null);
                }
            } while (true);


            foreach (var animal in animals)
                if (animal != null)
                    Console.WriteLine(animal);
                else
                    Console.WriteLine("Invalid input!");
        }
    }
}
public class Program
{
    // static void Main()
    // {
    //     var app = new Animals.StartUp();
    //     app.Run();
    //     Console.ReadKey(true);
    // }
}

