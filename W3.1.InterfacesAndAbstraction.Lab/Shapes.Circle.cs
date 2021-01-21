using System;

namespace Shapes
{
	class Circle : IDrawable
	{
		public int Radius { get; protected set; }

		public Circle(int radius)
		{
			Radius = radius;
		}

		public void Draw()
		{
			double rIn = Radius - 0.4;
			double rOut = Radius + 0.4;

			for (double y = Radius; y >= -Radius; y--)
			{
				for (double x = -Radius; x <= Radius; x += 0.5)
				{
					double value = x * x + y * y;

					if (value >= rIn * rIn && value <= rOut * rOut)
					{
						Console.Write("*");
					}
					else
					{
						Console.Write(" ");
					}
				}
				Console.WriteLine();
			}
		}
	}
}
