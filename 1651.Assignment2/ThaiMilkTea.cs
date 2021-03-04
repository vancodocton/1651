namespace _1651.Assignment2
{
	class ThaiMilkTea : IMilkTea
	{
		private double cost;
		public ThaiMilkTea()
		{
			cost = 10000;
		}
		public double GetCost()
		{
			return cost;
		}
		public string GetDescription()
		{
			return "Thai Milk Tea";
		}
	}
}
