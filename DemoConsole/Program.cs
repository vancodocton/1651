using System;

namespace DemoConsole
{
	class Program
	{
		static void Main()
		{
			var dog = new Dog();

			dog.Sound();

			dog.Fly();

			Console.ReadKey(true);

		}

	}
}
