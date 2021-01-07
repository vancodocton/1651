using System;

namespace csReview
{
	class Exercise3
	{
		private int Num;
		public void Run()
		{
			// Generate a random number from 1 to 100
			Random random = new Random();
			Num = random.Next(1, 100);

			Console.WriteLine("n is a number in range from 1 to 100");
			// Guessing n 7 time
			for (int i = 1; i <= 7; i++)
			{
				Console.Write($"Guessing {i} time, n = ");
				
				// check guessing result
				int n = int.Parse(Console.ReadLine());
				if (n == Num)
				{
					Console.WriteLine("Congratulations, You're winner!");
					return;
				}
				else
				{
					if ( n < Num)
						Console.WriteLine("Opps, You're wrong! Guessed number is smaller than n");
					else
						Console.WriteLine("Opps, You're wrong! Guessed number is bigger than n");
				}
			}

			// Print n if guessing fail
			Console.WriteLine("Sorry, You're fail!");
			Console.WriteLine($"n = {Num}");
			return;
		}


	}
}
