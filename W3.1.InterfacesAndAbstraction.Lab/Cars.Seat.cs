namespace Cars
{
	class Seat : ICar
	{

		public string Model { get; private set; }
		public string Color { get; private set; }

		public Seat(string model, string color)
		{
			Model = model;
			Color = color;
		}
		public string Start() => "Engine start";
		public string Stop() => "Breaaak!";

		public override string ToString()
		{
			return $"{Color} {base.GetType().Name} {Model}\n" + Start() + "\n" + Stop();
		}
	}
}
