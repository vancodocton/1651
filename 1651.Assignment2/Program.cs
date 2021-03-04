using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651.Assignment2
{
	class Program
	{
		static void Main()
		{
			//IMilkTea milkTea1 = new ThaiMilkTea();
			//milkTea1 = new BubbleDecorator(milkTea1);

			//IMilkTea milkTea2 = new ThaiMilkTea();
			//milkTea2 = new BubbleDecorator(milkTea2);
			//milkTea2 = new CreamDecorator(milkTea2);


			//Order order = new Order("1");

			//order.AddProduct(milkTea1);
			//order.AddProduct(milkTea2);

			//order.Print(true);

			//Console.WriteLine(milkTea1.GetDescription() + "; Cost: " + milkTea1.GetCost());
			//Console.WriteLine(milkTea2.GetDescription() + "; Cost: " + milkTea2.GetCost());

			MilkTeaShop milkTeaShop = new MilkTeaShop("Truong Duong's Thai Milk Tea Shop");
			milkTeaShop.Operate();
			Console.ReadKey();

		}
	}
}
