namespace _1651.Assignment2
{
	abstract class MilkTeaDecorator : MilkTea
	{
		protected MilkTea milkTea;
		public MilkTeaDecorator(MilkTea milkTea)
		{
			this.milkTea = milkTea;
		}
	}
}
