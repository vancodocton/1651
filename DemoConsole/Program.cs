using System;

namespace DemoConsole
{
	// Result of inheritance
	class Program
	{
		static void Main()
		{
			Animal animal = new Animal("Sky");
			animal.Run();
			animal.Hungry();

			Mouse mouse = new Mouse("Jerry");
			mouse.Run();
			mouse.Hungry();
			mouse.Hide();

			Cat cat = new Cat("Tom");
			cat.Run();
			cat.Hungry();
			cat.Climb();

			Console.ReadKey(true);
		}
	}
	// Program Output:
	// Animal is running
	// Sky is hungry
	// Mouse is running
	// Jerry is hungry
	// Jerry is hiding
	// Cat is running
	// Tom is hungry
	// Tom is climbing
}





