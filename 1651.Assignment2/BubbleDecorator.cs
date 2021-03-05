namespace _1651.Assignment2
{
	class BubbleDecorator : MilkTeaDecorator
	{
		private readonly double cost = 2000;
		public double Cost { get => cost; }

		public BubbleDecorator(MilkTea milkTea) : base(milkTea) { }

		private string AddBubble() => ", add Bubbles";
		public override double GetCost() => milkTea.GetCost() + cost;
		public override string GetDescription() => milkTea.GetDescription() + AddBubble();

	}
}
