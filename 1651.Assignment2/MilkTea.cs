namespace _1651.Assignment2
{
	abstract class MilkTea
	{
		public abstract double GetCost();
		public abstract string GetDescription();
		public override string ToString() => $"{GetDescription()}; Cost: {GetCost()}";
	}
}
