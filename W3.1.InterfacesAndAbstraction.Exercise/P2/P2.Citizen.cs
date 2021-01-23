namespace PersonInfo2
{
	class Citizen : PersonInfo1.IPerson, IBirthable, IIdentifiable
	{
		public string Birthdate { get; private set; }
		public string Id { get; private set; }
		public string Name { get; private set; }
		public int Age { get; private set; }

		public Citizen(string name, int age, string id, string birthdate)
		{
			Name = name;
			Age = age;
			Id = id;
			Birthdate = birthdate;
		}
	}
}
