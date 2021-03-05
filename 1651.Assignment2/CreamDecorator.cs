namespace _1651.Assignment2
{
	class CreamDecorator : MilkTeaDecorator
	{
		private readonly double cost = 4000;
		public double Cost { get => cost; }

		public CreamDecorator(MilkTea milkTea) : base(milkTea) { }

		private string AddCream() => ", add Cream";
		public override double GetCost() => milkTea.GetCost() + cost;
		public override string GetDescription() => milkTea.GetDescription() + AddCream();
	}
}
