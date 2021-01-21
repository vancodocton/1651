using System;

namespace Cars
{
	class StartUp
	{
		public static void Run()
		{
			ICar seat = new Seat("Leon", "Grey");
			ICar tesla = new Tesla("Model 3", "Red", 2);

			Console.WriteLine(seat);
			Console.WriteLine(tesla);
		}
	}
}
