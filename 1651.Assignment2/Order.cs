using System.Collections.Generic;

namespace _1651.Assignment2
{
	class Order : List<MilkTea>
	{
		public double TotalCost()
		{
			double totalCost = 0;

			foreach (MilkTea milkTea in this)
			{
				totalCost += milkTea.GetCost();
			}
			return totalCost;
		}
	}
}
