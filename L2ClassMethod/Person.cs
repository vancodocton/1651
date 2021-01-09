using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2ClassMethod
{
	class Person
	{
		private int age;
		private string name;

		public int Age { get => age;  set => age = value; }
		public string Name { get => name;  set => name = value; }

		public Person()
		{
		}
		public Person(int age1, string name1)
		{
			age = age1;
			name = name1;
		}
		public void DisplayPerson()
		{
			Console.WriteLine($"Name:\t{name}");
			Console.WriteLine($"Age: \t{age}");
		}
		public virtual void Input()
		{
			Console.Write("Please input name: ");
			name = Console.ReadLine();
			Console.Write("Please input age: ");
			age = int.Parse(Console.ReadLine());
		}

		public override string ToString()
		{
			return $"Name:\t{name}\nAge: \t{age}\n";
		}
	}
}
