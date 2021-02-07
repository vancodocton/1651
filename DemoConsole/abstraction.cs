using System;

namespace DemoConsole
{

	interface INamable
	{
		string Name { get; set; }
	}
	public abstract class Animal
	{
		public abstract void Eat();
		public abstract void Run();
	}
	public class Dog : Animal
	{
		public override void Eat() => Console.WriteLine("Dog is eating");
		public override void Run() => Console.WriteLine("Dog isrunning fast");
	}
	public class Cat : Animal, INamable
	{
		public string Name { get; set; }
		public Cat(string name) => Name = name;

		public override void Eat() => Console.WriteLine($"{Name} is eating");
		public override void Run() => Console.WriteLine($"{Name} is running fast");
	}
}
