using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
	public class StartUp
	{
		public static void Run()
		{
			var args = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

			var entities = new List<PersonInfo2.IIdentifiable>();
			while (args[0] != "End")
			{
				if (args.Length == 3)
				{
					var citizen = new Citizen(args[0], int.Parse(args[1]), args[2]);
					entities.Add(citizen);
				}
				else if (args.Length == 2)
				{
					var robot = new Robot(args[0], args[1]);
					entities.Add(robot);
				}

				args = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
			}

			string lastDigitsFakeId = Console.ReadLine();

			foreach (var entity in entities)
			{
				if (entity.Id.EndsWith(lastDigitsFakeId))
				{
					Console.WriteLine(entity.Id);
				}
			}
		}
	}
}
