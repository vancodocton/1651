using System;

namespace csReview
{
	class Exercise1
	{
		public void Run()
		{
			Console.Write("Enter n = ");
			int n = int.Parse(Console.ReadLine());

			int sum = 0;
			for (int i = 1; i <= n; i++)
			{
				sum += i;
			}

			Console.WriteLine("Sum of serial number from 1 to {0} is {1}", n, sum);
		}
	}
}
