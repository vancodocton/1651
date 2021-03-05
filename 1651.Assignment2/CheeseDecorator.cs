namespace _1651.Assignment2
{
	class CheeseDecorator : MilkTeaDecorator
	{
		private readonly double cost = 3000;
		public double Cost { get => cost; }

		public CheeseDecorator(MilkTea milkTea) : base(milkTea) { }

		private string AddCheese() => ", add Cheese";
		public override double GetCost() => milkTea.GetCost() + cost;
		public override string GetDescription() => milkTea.GetDescription() + AddCheese();
	}
}
