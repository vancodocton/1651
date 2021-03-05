using System;
using System.Collections.Generic;

namespace _1651.Assignment2
{
	sealed class ThaiMilkTeaShop
	{
		// store order list pending to pay
		private readonly List<Order> orders;
		private readonly Menu menu;
		private readonly string name;
		public string Name { get => name; }
		public ThaiMilkTeaShop()
		{
			name = "Truong Duong's Thai Milk Tea Shop";
			orders = new List<Order>();
			menu = new Menu(this.name);
		}
		public void Operate()
		{
			do
			{
				int option = int.Parse(menu.SelectOperateOption());
				switch (option)
				{
					case 0:
						menu.PromptExitMessage();
						return;
					case 1:
						CreateOrder();
						break;
					case 2:
						ShowOrderList();
						break;
					case 3:
						ShowOrderBill();
						break;
					case 4:
						PayOrder();
						break;
					case 5:
						menu.ShowShopMenu();
						break;
					default:
						menu.PromptInvalidOptionMessage();
						break;
				}
			} while (true);
		}
		private void CreateOrder()
		{
			Order newOrder = new Order();
			do
			{
				int option = int.Parse(menu.SelectCreateOrderOption());
				switch (option)
				{
					case 1:
						// add milk tea
						MilkTea milkTea = MixMilkTea();
						newOrder.Add(milkTea);
						break;
					case 2:
						// show order's temporary bill					
						menu.ShowTableOrderBill(newOrder);
						break;
					case 0:
						// save order
						menu.ShowTableOrderBill(newOrder);
						// confirm to save and exit
						if (menu.Confirm() == "y")
						{
							orders.Add(newOrder);
							return;
						}
						else menu.PromptActionCancel();
						break;
					default:
						menu.PromptInvalidOptionMessage();
						break;
				}
			} while (true);
		}
		private void ShowOrderList() => menu.ShowTableOrderList(orders);
		private void ShowOrderBill()
		{
			if (menu.ShowTableOrderList(orders))
			{
				int index = int.Parse(menu.SelectOrderIndex());
				menu.ShowTableOrderBill(orders[index]);
			}
		}
		private void PayOrder()
		{
			if (menu.ShowTableOrderList(orders))
			{
				int index = int.Parse(menu.SelectOrderIndex());

				menu.ShowTableOrderBill(orders[index]);

				if (menu.Confirm() == "y")
					menu.PromptPaymentSucessfulMessage();
				else
					menu.PromptActionCancel();
			}
		}
		private MilkTea MixMilkTea()
		{
			MilkTea mixingMilkTea;
			do
			{
				char[] availableOptions = new char[] { '0', '1', '2', '3' };
				string options = menu.SelectToppingOptions();

				if (options.IndexOfAny(availableOptions) == -1)
				{
					menu.PromptInvalidOptionMessage();
					continue;
				}

				mixingMilkTea = new ThaiMilkTea();
				if (options != "0")
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
						}

				menu.ShowMilkTeaInfo(mixingMilkTea);
				if (menu.Confirm() == "y")
					break;
				else menu.PromptActionCancel();
			} while (true);
			return mixingMilkTea;
		}
	}
}
