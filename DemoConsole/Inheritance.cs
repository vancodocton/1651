using System;

namespace DemoConsole
{
	// define class Animal
	class Animal
	{
		public string Name { get; }
		public Animal(string name) => Name = name;
		public void Run() => Console.WriteLine($"{GetType().Name} is running");
		public void Hungry() => Console.WriteLine($"{Name} is hungry");
	}
	// define class Dog inherited class Animal
	class Mouse : Animal
	{
		public Mouse(string name) : base(name) { }
		public void Hide() => Console.WriteLine($"{Name} is hiding");
	}
	// define class Cat inherited class Animal
	class Cat : Animal
	{
		public Cat(string name) : base(name) { }
		public void Climb() => Console.WriteLine($"{Name} is climbing");
	}
}
