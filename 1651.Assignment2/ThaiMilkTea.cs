namespace _1651.Assignment2
{
	class ThaiMilkTea : MilkTea
	{
		private readonly double cost = 10000;

		public override double GetCost() => cost;
		public override string GetDescription() => "Thai Milk Tea";
	}
}
