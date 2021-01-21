using System;
using System.Collections.Generic;

namespace PersonsInfo
{
	public class Team
	{
		public string Name { get; private set; }
		public List<Person3> First { get; }
		public List<Person3> Reserve { get; }

		public Team(string name)
		{
			if (!string.IsNullOrWhiteSpace(name))
				Name = name;
			else
				throw new ArgumentException("Team name is null, empty or only consists of white-space characters");
			First = new List<Person3>();
			Reserve = new List<Person3>();
		}
		public void AddPlayer(Person3 person)
		{
			if (person.Age < 40)
				First.Add(person);
			else
				Reserve.Add(person);
		}
	}
}
