namespace DemoConsole
{
	class Person
	{
		private int id;
		private string name;
		private int age;

		public int Id { get => id; private set => id = value; }
		public string Name { get => name; private set => name = value; }
		public int Age { get => age; private set => age = value; }

		public Person(int id, string name, int age)
		{
			this.id = id;
			this.name = name;
			this.age = age;
		}
		public void ModifyName(string newname)
		{
			this.name = newname;
		}
		public override string ToString()
		{
			return $"ID: {id}, Name: {name}, Age: {age}";
		}
	}
}
