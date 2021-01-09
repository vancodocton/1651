namespace L2ClassMethod
{
	class MathFranction
	{
		public static Fraction Add(Fraction a, Fraction b)
		{
			int numerator = a.Numerator * b.Denominator + b.Numerator * a.Denominator;
			int denominator = a.Denominator * b.Denominator;

			return new Fraction(numerator, denominator);
		}

		public static Fraction Subtract(Fraction a, Fraction b)
		{
			int numerator = a.Numerator * b.Denominator - b.Numerator * a.Denominator;
			int denominator = a.Denominator * b.Denominator;

			return new Fraction(numerator, denominator);
		}

		public static Fraction Multiply(Fraction a, Fraction b)
		{
			int numerator = a.Numerator * b.Numerator;
			int denominator = a.Denominator * b.Denominator;

			return new Fraction(numerator, denominator);
		}
		public static Fraction Divide(Fraction a, Fraction b)
		{
			int numerator = a.Numerator * b.Denominator;
			int denominator = a.Denominator * b.Numerator;

			return new Fraction(numerator, denominator);
		}
	}
}
