namespace Cars
{
	class Tesla : ICar, IElectricCar
	{
		public string Model { get; private set; }
		public string Color { get; private set; }
		public int Battery { get; private set; }

		public Tesla(string model, string color, int battery)
		{
			Model = model;
			Color = color;
			Battery = battery;
		}
		public string Start() => "Engine start";
		public string Stop() => "Breaaak!";
		public override string ToString()
		{
			return $"{Color} {base.GetType().Name} {Model} with {Battery} Batteries\n" + Start() + "\n" + Stop();
		}
	}
}
