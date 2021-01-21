using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonsInfo;

namespace W2._2Encapsulation.Lab
{
	public class FirstAndReserveTeam
	{
		public void Run()
		{
			var personNumber = int.Parse(Console.ReadLine());

			var persons = new List<Person3>();
			for (int i = 0; i < personNumber; i++)
			{
				string[] line = Console.ReadLine().Split(' ');
				var firstName = line[0];
				var lastName = line[1];
				var age = int.Parse(line[2]);
				var salary = decimal.Parse(line[3]);

				var person = new Person3(firstName, lastName, age, salary);
				persons.Add(person);
			}

			var team = new Team("SoftUni");
			foreach (var person in persons)
				team.AddPlayer(person);

			Console.WriteLine($"First team has {team.First.Count} players.");
			Console.WriteLine($"Reserve team has {team.Reserve.Count} players.");
		}
	}
}
