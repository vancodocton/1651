using System;
using System.Numerics;

namespace Lab00ObjectsAndClasses
{
	class BigFactorial
	{
		public void Run()
		{
			int n = int.Parse(Console.ReadLine());

			BigInteger factorial = 1;

			for (int i = 2; i <= n; i++)
			{
				factorial *= i;
			}
			Console.WriteLine(factorial);

		}
	}
}
