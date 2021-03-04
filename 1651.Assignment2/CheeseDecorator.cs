namespace _1651.Assignment2
{
	class CheeseDecorator : MilkTeaDecorator
	{
		private double cost;
		public double Cost { get => cost; private set => cost = value; }

		public CheeseDecorator(MilkTea milkTea) : base(milkTea)
		{
			cost = 3000;
		}
		public CheeseDecorator(MilkTea milkTea, double cost) : base(milkTea)
		{
			this.cost = cost;
		}

		private string AddCheese() => ", add Cheese";
		public override double GetCost() => milkTea.GetCost() + cost;
		public override string GetDescription() => milkTea.GetDescription() + AddCheese();
	}
}
