using System;

namespace csReview
{
	class Dice
	{
		public int Sides { get; private set; }
		public Dice(int sides = 6)
		{
			Sides = sides;
		}
		//public Dice()
		//{
		//	Sides = 6;
		//}
		public int Roll()
		{

			var random = new Random();
			return random.Next(1, Sides + 1);
		}
	}
}
