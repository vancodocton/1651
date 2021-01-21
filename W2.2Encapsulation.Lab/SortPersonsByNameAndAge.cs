using PersonsInfo;
using System;
using System.Collections.Generic;
using System.Linq;

namespace W2._2Encapsulation.Lab
{
	public class SortPersonsByNameAndAge
	{
		public void Run()
		{
			var personNumber = int.Parse(Console.ReadLine());

			var persons = new List<Person1>();
			for (int i = 0; i < personNumber; i++)
			{
				string[] line = Console.ReadLine().Split(' ');
				var firstName = line[0];
				var lastName = line[1];
				var age = int.Parse(line[2]);
				persons.Add(new Person1(firstName, lastName, age));
			}

			persons = persons.OrderBy(p => p.FirstName).ThenBy(p => p.Age).ToList();

			foreach (var person in persons)
				Console.WriteLine(person);
		}
	}
}
