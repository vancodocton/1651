namespace BirthdayCelebrations
{
	class Pet : PersonInfo2.IBirthable
	{
		public string Name { get; private set; }
		public string Birthdate { get; private set; }

		public Pet(string name, string birthdate)
		{
			Name = name;
			Birthdate = birthdate;
		}
	}
}
