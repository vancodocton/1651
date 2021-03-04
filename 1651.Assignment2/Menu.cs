using System;

namespace _1651.Assignment2
{
	class Menu
	{
		public static void BreakLine() => Console.WriteLine("------------------------------------");
		public static void PrintOperateOption()
		{
			//Menu.BreakLine();
			Console.WriteLine("Select 1 for create oder");
			Console.WriteLine("Select 2 for delete order");
			Console.WriteLine("Select 3 for show order list");
			Console.WriteLine("Select 4 for show order with index");
			Console.WriteLine("Select 5 for pay order with index");
			Console.WriteLine("Select 0 for exit");
			Menu.BreakLine();
			//Console.Write("Your option: ");
		}
		public static void PrintCreateOrderOption()
		{
			//Menu.BreakLine();
			Console.WriteLine("Select 1 for add beverabe");
			Console.WriteLine("Select 2 for delete beverabe");
			Console.WriteLine("Select 3 for show temporary oder");
			Console.WriteLine("Select 0 for save oder");
			Menu.BreakLine();
			//Console.Write("Your option: ");
		}
		public static void PrintToppingOptionList()
		{
			//Menu.BreakLine();
			Console.WriteLine("Select 1 for Bubble");
			Console.WriteLine("Select 2 for Cheese");
			Console.WriteLine("Select 3 for Cream");
			Console.WriteLine("Select 0 for nothing");
			Menu.BreakLine();
			//Console.Write("Your option: ");
		}
	}
}
