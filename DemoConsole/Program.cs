using System;
using System.Collections.Generic;

namespace DemoConsole
{
	class Program
	{
		static void Main()
		{
			List<int> list = new List<int>() { 5, 9, 6, 3, 4, 2, 1, 7 };

			list.Sort();

			Console.ReadKey(true);
		}
	}
}
