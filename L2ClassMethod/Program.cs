using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2ClassMethod
{
	class Program
	{
		static void Main()
		{
			int a = 10;
			int b = -20;

			int c = -4;
			int d = -6;

			var fraction1 = new Fraction(a, b);
			var fraction2 = new Fraction(c, d);

			Console.WriteLine(fraction1.ToString());
			Console.WriteLine(fraction2);

			Console.WriteLine(MathFranction.Divide(fraction1, fraction2).ToDecimal());
			Console.ReadKey(true);
		}
	}
}
