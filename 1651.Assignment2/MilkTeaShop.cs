using System;
using System.Collections.Generic;

namespace _1651.Assignment2
{
	sealed class MilkTeaShop
	{
		// store order list pending to pay
		private readonly List<Order> ordersList;
		private readonly Menu menu;
		private readonly string name;
		public string Name { get => name; }
		public MilkTeaShop()
		{
			name = "Truong Duong's Thai Milk Tea Shop";
			ordersList = new List<Order>();
			menu = new Menu(this.name);
		}
		private string Confirm()
		{
			Console.Write("Are you sure (Enter y to continue)? ");
			return Console.ReadLine();
		}
		public void Operate()
		{
			menu.PrintOperateOption();

			do
			{
				Console.Write("Opreating option: ");
				int option = int.Parse(Console.ReadLine());

				switch (option)
				{
					case 0:
						Console.WriteLine("Thanks to using");
						return;
					case 1:
						CreateOrder();
						break;
					case 2:
						if (ordersList.Count == 0)
							Console.WriteLine("Orders list is empty");
						else ShowOrderList();
						break;
					case 3:
						if (ordersList.Count == 0)
							Console.WriteLine("Orders list is empty");
						else ShowOrderBill();
						break;
					case 4:
						if (ordersList.Count == 0)
							Console.WriteLine("Orders list is empty");
						else PayOrder();
						break;
					case 5:
						menu.ShowShopMenu();
						break;
					default:
						Console.WriteLine("Invalid option!");
						break;
				}
			} while (true);
		}
		private void CreateOrder()
		{
			Order newOrder = new Order();
			menu.PrintCreateOrderOption();
			do
			{
				Console.Write("Create-order option: ");
				int option = int.Parse(Console.ReadLine());

				switch (option)
				{
					case 1:
						Console.WriteLine("Add milktea...");
						MilkTea milkTea = MixMilkTea();
						newOrder.AddItem(milkTea);
						break;
					case 2:
						Console.WriteLine("Show temporary bill...");
						newOrder.PrintBill();
						break;
					case 0:
						Console.WriteLine("Save order...");
						newOrder.PrintBill();
						// confirm to save and exit
						if (Confirm() == "y")
						{
							ordersList.Add(newOrder);
							return;
						}
						else Console.WriteLine("Action cancel!");
						break;
					default:
						Console.WriteLine("Invalid option!");
						break;
				}
			} while (true);
		}
		private MilkTea MixMilkTea()
		{
			MilkTea mixingMilkTea;
			menu.PrintToppingOptions();
			do
			{
				char[] availableOptions = new char[] { '0', '1', '2', '3' };
				Console.Write("Add toppings options: ");
				string options = Console.ReadLine();

				if (options.IndexOfAny(availableOptions) == -1)
				{
					Console.WriteLine("Invalid option!");
					continue;
				}
				else if (options != "0")
				{
					bool flag = true;
					mixingMilkTea = new ThaiMilkTea();
					foreach (char option in options)
						switch (option)
						{
							case '1':
								mixingMilkTea = new BubbleDecorator(mixingMilkTea);
								break;
							case '2':
								mixingMilkTea = new CheeseDecorator(mixingMilkTea);
								break;
							case '3':
								mixingMilkTea = new CreamDecorator(mixingMilkTea);
								break;
							default:
								Console.WriteLine("Invalid option!");
								flag = false;
								break;
						}
					if (flag == false)
						continue;

					Console.WriteLine(mixingMilkTea.ToString());
					if (Confirm() == "y")
						return mixingMilkTea;
					else Console.WriteLine("Action cancel!");
				}
			} while (true);			
		}
		private void ShowOrderList()
		{
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
		}

		private string SelectOrderIndex()
		{
			Console.Write("Enter order index for action: ");
			return Console.ReadLine();
		}
		private void ShowOrderBill()
		{
			ShowOrderList();
			int index = int.Parse(SelectOrderIndex());
			ordersList[index].PrintBill();
		}
		private void PayOrder()
		{
			ShowOrderList();
			int index = int.Parse(SelectOrderIndex());
			ordersList[index].PrintBill();

			if (Confirm() == "y")
			{
				ordersList.RemoveAt(index);
				Console.WriteLine("Order has been paid!");
			}
			else Console.WriteLine("Action cancel!");
		}
	}
}
