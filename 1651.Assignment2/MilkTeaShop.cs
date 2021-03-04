using System;
using System.Collections.Generic;

namespace _1651.Assignment2
{
	partial class MilkTeaShop
	{
		private List<Order> ordersList;
		public string Name { get; private set; }
		public MilkTeaShop(string name)
		{
			Name = name;
			ordersList = new List<Order>();
		}
		public void Operate()
		{
			Console.WriteLine("\tWelcome to " + Name);
			Menu.BreakLine();
			int option;
			int index;
			do
			{
				Menu.PrintOperateOption();
				Console.Write("Opreating option: ");
				option = int.Parse(Console.ReadLine());

				switch (option)
				{
					case 1:
						CreateOrder();
						break;
					case 2:
						index = SelectOrderIndex();
						DeleteOrder(index);
						break;
					case 3:
						ShowOrderList();
						break;
					case 4:
						index = SelectOrderIndex();
						ShowOrder(index);
						break;
					case 5:
						index = SelectOrderIndex();
						PayOrder(index);
						break;
					case 0:
						Console.WriteLine("Thanks for using");
						return;
					default:
						Console.WriteLine("Invalid option!");
						break;
				}
			} while (true);
		}
		private void CreateOrder()
		{
			Order order = new Order("unknown ID");
			Console.WriteLine("Order ID: " + order.Id);

			int option;
			do
			{
				Menu.PrintCreateOrderOption();
				Console.Write("Create-order option: ");
				option = int.Parse(Console.ReadLine());

				switch (option)
				{
					case 1:
						IMilkTea milkTea = MixMilkTea();
						order.Add(milkTea);
						break;
					case 2:
						Console.Write("Enter beverage index for delete: ");
						int index = int.Parse(Console.ReadLine());
						try
						{
							order.PrintBill(true);
							Console.Write("Are you sure (Enter y for continue)? ");

							if (Console.ReadLine() == "y")
								order.RemoveAt(index);
							else
								Console.WriteLine("Action cancel!");

						}
						catch (ArgumentOutOfRangeException e)
						{
							Console.WriteLine(e.Message);
						}
						break;
					case 3:
						order.PrintBill(false);
						break;
					case 0:
						order.PrintBill(true);
						Console.Write("Are you sure (Enter y for continue)? ");

						if (Console.ReadLine() == "y")
						{
							ordersList.Add(order);
							return;
						}
						else continue;
					default:
						Console.WriteLine("Invalid option!");
						break;
				}
			} while (true);
		}
		private bool DeleteOrder(int index)
		{
			ordersList[index].PrintBill(true);
			Console.Write("Are you sure (Enter y for continue)? ");

			if (Console.ReadLine() == "y")
			{
				ordersList.RemoveAt(index);
				return true;
			}
			Console.WriteLine("Action canceled!");
			return false;
		}
		private void ShowOrderList()
		{
			Console.WriteLine("Total order number: ", +ordersList.Count);

			Console.WriteLine("| {0,3} | {1,15} | {2,20} | {3} ", "NO", "Order Id", "Number of Beverages", "Total Cost");
			for (int i = 0; i < ordersList.Count; i++)
				Console.WriteLine("| {0,3} | {1,15} | {2,20} | {3} ", i, ordersList[i].Id, ordersList[i].Count, ordersList[i].TotalCost());
			Menu.BreakLine();
		}
		private void ShowOrder(int index)
		{
			ordersList[index].PrintBill(true);
		}
		private void PayOrder(int index)
		{
			Order order = ordersList[index];
			if (DeleteOrder(index))
			{
				// code for save order to database
				Console.WriteLine("Order has been paid!");
			}
		}
		private IMilkTea MixMilkTea()
		{
			IMilkTea milkTea = new ThaiMilkTea();
			Console.WriteLine("Beverage: " + milkTea.GetDescription());

			Menu.PrintToppingOptionList();
			int option;
			do
			{
				Console.Write("Add toppings option: ");
				option = int.Parse(Console.ReadLine());

				switch (option)
				{
					case 1:
						milkTea = new BubbleDecorator(milkTea);
						break;
					case 2:
						milkTea = new CheeseDecorator(milkTea);
						break;
					case 3:
						milkTea = new CreamDecorator(milkTea);
						break;
					case 0:
						Console.WriteLine("Product: " + milkTea.GetDescription());
						Console.WriteLine("Cost:    " + milkTea.GetCost());
						Console.Write("Are you sure (Enter y for continue)? ");

						if (Console.ReadLine() == "y") break;
						else continue;
					default:
						Console.WriteLine("Invalid option!");
						break;
				}
			} while (option != 0);
			return milkTea;
		}
		private int SelectOrderIndex()
		{
			Console.Write("Enter Order Id for action: ");
			return int.Parse(Console.ReadLine());
		}
	}
}
