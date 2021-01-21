using Persons;
using System;

namespace W2.Inheritance.Exercise
{
	class Program
	{
		static void Main()
		{
			var person = new Person("Nguyen Ky Duong Truong", 19);

			person = new Child("Nguyen Ky Bao An", 16);

			Console.WriteLine(person);
			Console.ReadKey(true);
		}
	}
}
