namespace _1651.Assignment2
{
	abstract class MilkTeaDecorator : IMilkTea
	{
		protected IMilkTea milkTea;
		public MilkTeaDecorator(IMilkTea milkTea)
		{
			this.milkTea = milkTea;
		}

		public abstract double GetCost();
		public abstract string GetDescription();
	}
}
