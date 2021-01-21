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
}
