using System;
namespace csReview
{
	class Exercise2
	{
		public void Run()
		{
			int n = InputNum();

			if (CheckPrime(n))
				Console.WriteLine($"{n} is a prime");
			else
				Console.WriteLine($"{n} is not a prime");
		}

		private int InputNum()
		{
			int n;

			do
			{
				Console.Write("Enter n bigger than 1: ");
				n = int.Parse(Console.ReadLine());
			} while (n < 2);

			return n;
		}

		private bool CheckPrime(int n)
		{
			int sqrtNum = (int)Math.Sqrt(n);

			for (int i = 2; i <= sqrtNum; i++)
				if (n % i == 0)
					return false;

			return true;
		}
	}
}
