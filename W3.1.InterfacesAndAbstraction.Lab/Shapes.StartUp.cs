using System;

namespace Shapes
{
	public class StartUp
	{
		public static void Run()
		{
			var radius = int.Parse(Console.ReadLine());
			var width = int.Parse(Console.ReadLine());
			var height = int.Parse(Console.ReadLine());


			var circle = new Circle(radius);
			var rectangle = new Rectangle(width, height);

			circle.Draw();
			rectangle.Draw();
		}
	}

}
