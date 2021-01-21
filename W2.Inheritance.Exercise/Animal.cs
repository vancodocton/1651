namespace Zoo
{
	public class Animal
	{
		protected string name;
		protected string Name { get => name; set => name = value; }

		public Animal()
		{
			this.name = "";
		}
		public Animal(string name)
		{
			this.name = name;
		}
	}
}
