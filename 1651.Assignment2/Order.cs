using System;
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
		public void AddItem(MilkTea milkTea)
		{
			this.Add(milkTea);
		}
		public void PrintBill()
		{
			Console.WriteLine("| NO |   Cost   | Description");
			for (int i = 0; i < this.Count; i++)
				Console.WriteLine("| {0,2} | {1,8} | {2}", i, this[i].GetCost(), this[i].GetDescription());
		}
	}
}
