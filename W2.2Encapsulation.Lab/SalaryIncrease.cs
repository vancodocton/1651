using PersonsInfo;
using System;
using System.Collections.Generic;

namespace W2._2Encapsulation.Lab
{
	class SalaryIncrease
	{
		public void Run()
		{
			var personNumber = int.Parse(Console.ReadLine());

			var persons = new List<Person2>();
			for (int i = 0; i < personNumber; i++)
			{
				string[] line = Console.ReadLine().Split(' ');
				var firstName = line[0];
				var lastName = line[1];
				var age = int.Parse(line[2]);
				var salary = decimal.Parse(line[3]);
				persons.Add(new Person2(firstName, lastName, age, salary));
			}

			var salaryRaisePercent = decimal.Parse(Console.ReadLine());

			foreach (var person in persons)
			{
				person.RaiseSalary(salaryRaisePercent);
				Console.WriteLine(person);
			}
		}
	}
}
