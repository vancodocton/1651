namespace _1651.Assignment2
{
	class BubbleDecorator : MilkTeaDecorator
	{
		private double cost;
		public double Cost { get => cost; private set => cost = value; }

		public BubbleDecorator(MilkTea milkTea) : base(milkTea)
		{
			cost = 2000;
		}
		public BubbleDecorator(MilkTea milkTea, double cost) : base(milkTea)
		{
			this.cost = cost;
		}

		private string AddBubble() => ", add Bubbles";
		public override double GetCost() => milkTea.GetCost() + cost;
		public override string GetDescription() => milkTea.GetDescription() + AddBubble();

	}
}
