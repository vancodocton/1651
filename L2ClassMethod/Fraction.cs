using System;

namespace L2ClassMethod
{
	class Fraction
	{
		public int Numerator { get; private set; }
		public int Denominator { get; private set; }
		public Fraction(int numerator, int denominator)
		{
			if (denominator == 0)
				throw new DivideByZeroException();

			int gcd = GCD(numerator, denominator);
			Numerator = numerator / gcd;
			Denominator = denominator / gcd;

			if (Denominator < 0)
			{
				Denominator *= -1;
				Numerator *= -1;
			}
		}
		protected static int GCD(int a, int b)
		{
			if (Math.Abs(a) < Math.Abs(b))
				Swap(ref a, ref b);

			int tmp;
			while (b != 0)
			{
				tmp = b;
				b = a % b;
				a = tmp;
			}
			return a;
		}
		protected static void Swap(ref int a, ref int b)
		{
			int tmp = a;
			a = b;
			b = tmp;
		}
		public override string ToString()
		{
			return $"{Numerator} / {Denominator}\n";
		}
		public decimal ToDecimal()
		{
			return (decimal)Numerator / Denominator;
		}
	}
}
