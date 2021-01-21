using System;

namespace Persons
{
	public class Child : Person
	{
		public Child(string name, int age) : base (name, age)
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
