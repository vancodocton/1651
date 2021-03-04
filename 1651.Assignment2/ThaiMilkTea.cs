namespace _1651.Assignment2
{
	class ThaiMilkTea : MilkTea
	{
		private double cost;
		public ThaiMilkTea()
		{
			cost = 10000;
		}
		public override double GetCost()
		{
			return cost;
		}
		public override string GetDescription()
		{
			return "Thai Milk Tea";
		}
	}
}
