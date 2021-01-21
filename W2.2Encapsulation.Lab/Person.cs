using System;

namespace PersonsInfo
{
	public class Person1
	{
		public string FirstName { get; protected set; }
		public string LastName { get; protected set; }
		public int Age { get; protected set; }

		public Person1(string firstName, string lastName, int age)
		{
			FirstName = firstName;
			LastName = lastName;
			Age = age;
		}
		public override string ToString()
		{
			return $"{this.FirstName} {this.LastName} is {this.Age} years olds.";
		}
	}
	public class Person2 : Person1
	{
		public decimal Salary { get; protected set; }

		public Person2(string firstName, string lastName, int age, decimal salary) : base(firstName, lastName, age)
		{
			Salary = salary;
		}
		public void RaiseSalary(decimal raisePercent) => Salary *= (raisePercent / 100 + 1);
		public override string ToString()
		{
			return $"{FirstName} {LastName} receives {Decimal.Round(Salary, 2)} leva.";
		}
	}
	public class Person3
	{
		private string firstName;
		private string lastName;
		private int age;
		private decimal salary;

		public Person3(string firstName, string lastName, int age, decimal salary)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Age = age;
			this.Salary = salary;
		}
		public string FirstName
		{
			get => firstName; protected set
			{
				if (value.Length < 3)
					throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
				firstName = value;
			}
		}
		public string LastName
		{
			get => lastName; protected set
			{
				if (value.Length < 3)
					throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
				lastName = value;
			}
		}
		public int Age
		{
			get => age;
			private set
			{
				if (value < 0)
					throw new ArgumentException("Age cannot be zero or a negative integer!");
				age = value;
			}
		}
		public decimal Salary
		{
			get => salary; protected set
			{
				if (value < 460)
					throw new ArgumentException("Salary cannot be less than 460 leva!");
				salary = value;
			}
		}
		public override string ToString()
		{
			return $"{FirstName} {LastName} gets {Decimal.Round(Salary, 2)} leva.";
		}
		public void RaiseSalary(decimal raisePercent) => Salary *= (raisePercent / 100 + 1);
	}

}
