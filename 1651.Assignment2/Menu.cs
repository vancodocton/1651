using System;
using System.Collections.Generic;

namespace _1651.Assignment2
{
	class Menu
	{
		// Print Break Line between section
		public void BreakLine(char chr)
		{
			for (int i = 0; i < 80; i++) Console.Write(chr);
			Console.WriteLine();
		}
		// Print Operating Option
		public void PrintOperateOption()
		{
			BreakLine('#');
			Console.WriteLine($"Welcome to the shop");
			Console.WriteLine("Enter 1 to create order");
			Console.WriteLine("Enter 2 to show order list");
			Console.WriteLine("Enter 3 to show order's bill");
			Console.WriteLine("Enter 4 to pay order");
			Console.WriteLine("Enter 5 to show shop's menu");
			Console.WriteLine("Enter 0 to exit");
			BreakLine('-');
		}
		public void PrintCreateOrderOption()
		{
			BreakLine('*');
			Console.WriteLine("Create order");
			Console.WriteLine("Enter 1 to add milk tea");
			Console.WriteLine("Enter 2 to show order's temporary bill");
			Console.WriteLine("Enter 0 to save order");
			BreakLine('-');
		}
		public void PrintToppingOptions()
		{
			BreakLine('+');
			Console.WriteLine("Add toppings for Thai Milk Tea");
			Console.WriteLine("Enter 1 add Bubble");
			Console.WriteLine("Enter 2 add Cheese");
			Console.WriteLine("Enter 3 add Cream");
			Console.WriteLine("Enter 0 add nothing");
			BreakLine('-');
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
