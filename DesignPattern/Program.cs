using System;

namespace DesignPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			Singleton p1 = Singleton.GetInstance();
			p1.Property = "pp1";

			Singleton p2 = Singleton.GetInstance();
			p2.Property = "pp2";

			Console.WriteLine(p1.Property);
			Console.WriteLine(p2.Property);

			Console.ReadKey(true);
		}
		/* Output
		 * pp2
		 * pp2
		 */
	}
}
