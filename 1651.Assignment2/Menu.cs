using System;
using System.Collections.Generic;

namespace _1651.Assignment2
{
	class Menu
	{
		private readonly string milkTeaShopName;

		public Menu(string milkTeaShopName)
		{
			this.milkTeaShopName = milkTeaShopName;
		}

		// Print Break Line between section
		public void BreakLine(char chr)
		{
			for (int i = 0; i < 80; i++) Console.Write(chr);
			Console.WriteLine();
		}
		// Print Operating Option
		public string SelectOperateOption()
		{
			BreakLine('#');
			Console.WriteLine($"Welcome to {milkTeaShopName}");
			Console.WriteLine("Enter 1 to create order");
			Console.WriteLine("Enter 2 to show order list");
			Console.WriteLine("Enter 3 to show order's bill");
			Console.WriteLine("Enter 4 to pay order");
			Console.WriteLine("Enter 5 to show shop's menu");
			Console.WriteLine("Enter 0 to exit");
			BreakLine('-');
			Console.Write("Opreating option: ");
			string option = Console.ReadLine();
			return option;
		}
		public string SelectCreateOrderOption()
		{
			BreakLine('*');
			Console.WriteLine("Create order");
			Console.WriteLine("Enter 1 to add milk tea");
			Console.WriteLine("Enter 2 to show order's temporary bill");
			Console.WriteLine("Enter 0 to save order");
			BreakLine('-');
			Console.Write("Create-order option: ");
			string option = Console.ReadLine();
			return option;
		}
		public string SelectToppingOptions()
		{
			BreakLine('+');
			Console.WriteLine("Add toppings for Thai Milk Tea");
			Console.WriteLine("Enter 1 add Bubble");
			Console.WriteLine("Enter 2 add Cheese");
			Console.WriteLine("Enter 3 add Cream");
			Console.WriteLine("Enter 0 add nothing");
			BreakLine('-');
			Console.Write("Add toppings options: ");
			string option = Console.ReadLine();
			return option;
		}
		public string SelectOrderIndex()
		{
			Console.Write("Enter order index for action: ");
			return Console.ReadLine();
		}
		public string Confirm()
		{
			Console.Write("Are you sure (Enter y to continue)? ");
			return Console.ReadLine();
		}
		public void PromptExitMessage() => Console.WriteLine("Thanks to using");
		public void PromptPaymentSucessfulMessage() => Console.WriteLine("Order has been paid!");
		public void PromptInvalidOptionMessage() => Console.WriteLine("Invalid option!");
		public void PromptActionCancel() => Console.WriteLine("Action cancel!");
		public void ShowMilkTeaInfo(MilkTea milkTea) => Console.WriteLine(milkTea);
		public bool ShowTableOrderList(List<Order> ordersList)
		{
			if (ordersList.Count == 0)
			{
				Console.WriteLine("Orders list is empty");
				return false;
			}
			Console.WriteLine("Total orders number: {0}", ordersList.Count);
			Console.WriteLine("| {0,3} | {1,20} | {2} ",
				"NO",
				"Number of Beverages",
				"Total Cost");
			for (int i = 0; i < ordersList.Count; i++)
				Console.WriteLine("| {0,3} | {1,20} | {2} ",
					i,
					ordersList[i].Count,
					ordersList[i].TotalCost());
			return true;
		}
		public void ShowTableOrderBill(Order order)
		{
			//Console.WriteLine("Total cost: " + order.TotalCost());
			Console.WriteLine("| NO |   Cost   | Description");
			for (int i = 0; i < order.Count; i++)
				Console.WriteLine("| {0,2} | {1,8} | {2}", i, order[i].GetCost(), order[i].GetDescription());
		}
		public void ShowShopMenu()
		{
			Console.WriteLine("Beverage: ");
			Console.WriteLine("\tThai Milk Tea: 10000");
			Console.WriteLine("Milk Tea Toppings:");
			Console.WriteLine("\tBubbles: 2000");
			Console.WriteLine("\tCream  : 3000");
			Console.WriteLine("\tCheese : 4000");
		}
	}
}
