using System;

namespace DemoConsole
{
	// Overloading in C#
	class Caculation
	{
		public static int Sum(int a, int b)
		{
			return a + b;
		}
		public static int Sum(int a, int b, int c)
		{
			return a + b + c;
		}
	}
	// Result of Overloading
	class Program
	{
		static void Main()
		{
			Console.WriteLine(Caculation.Sum(5, 6));
			Console.WriteLine(Caculation.Sum(4, 2, 9));

			Console.ReadKey(true);
		}
		// Output
		/* 
		 * 11
		 * 15
		 */
	}
}





