using PersonsInfo;
using System;
using System.Collections.Generic;
using System.Text;

namespace W2._2Encapsulation.Lab
{
	public class ValidationOfData
	{
		public void Run()
		{
			var personNumber = int.Parse(Console.ReadLine());
			var builder = new StringBuilder();
			var persons = new List<Person3>();

			for (int i = 0; i < personNumber; i++)
			{
				string[] line = Console.ReadLine().Split(' ');
				var firstName = line[0];
				var lastName = line[1];
				var age = int.Parse(line[2]);
				var salary = decimal.Parse(line[3]);
				try
				{
					var person = new Person3(firstName, lastName, age, salary);
					persons.Add(person);
				}
				catch (ArgumentException error)
				{
					persons.Add(null);
					builder.AppendLine(error.Message);
				}
			}
			var salaryRaisePercent = decimal.Parse(Console.ReadLine());

			Console.Write(builder);
			foreach (var person in persons)
				if (person != null)
				{
					person.RaiseSalary(salaryRaisePercent);
					Console.WriteLine(person);
				}
		}
	}
}
