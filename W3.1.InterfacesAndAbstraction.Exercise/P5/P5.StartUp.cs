using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCelebrations
{
	public class StartUp
	{
		public static void Run()
		{
			var entities = new List<PersonInfo2.IBirthable>();

			var args = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

			while (args[0] != "End")
			{
				switch (args[0])
				{
					case "Citizen":
						var citizen = new PersonInfo2.Citizen(args[1], int.Parse(args[2]), args[3], args[4]);
						entities.Add(citizen);
						break;
					case "Pet":
						var pet = new Pet(args[1], args[2]);
						entities.Add(pet);
						break;
					default:
						break;
				}

				args = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
			}

			string year = Console.ReadLine();
			foreach (var entity in entities)
			{
				if (entity.Birthdate.EndsWith(year))
					Console.WriteLine(entity.Birthdate);
			}
		}
	}
}
