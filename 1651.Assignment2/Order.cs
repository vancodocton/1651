using System;
using System.Collections.Generic;

namespace _1651.Assignment2
{
	class Order : List<MilkTea>
	{
		private string id;
		public string Id { get => id; }
		public double TotalCost()
		{
			double totalCost = 0;

			foreach (MilkTea milkTea in this)
			{
				totalCost += milkTea.GetCost();
			}
			return totalCost;
		}
		public Order(string id)
		{
			this.id = id;
		}
		public void PrintBill(bool isHasId)
		{
			if (isHasId) Console.WriteLine(" Order Id:  " + id);
			Console.WriteLine("Total cost: " + TotalCost());
			Console.WriteLine("| NO |   Cost   | Description");
			for (int i = 0; i < this.Count; i++)
				Console.WriteLine("| {0,2} | {1,8} | {2}", i, this[i].GetCost(), this[i].GetDescription());
		}
	}
}
