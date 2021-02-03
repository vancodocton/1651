// declare libraries
using System;

namespace DemoConsole
{
	// define class
	public class Person
	{
		// define properties
		public string Name { get; }
		public int Age { get; }

		// define constructor
		public Person(string name, int age)
		{
			Name = name;
			Age = age;
		}

		// define method
		public void Greet()
		{
			Console.WriteLine("Hello");
		}
	}
}
