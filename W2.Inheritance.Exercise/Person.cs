using System;

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
}
