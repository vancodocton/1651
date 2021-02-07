using System;

namespace DemoConsole
{
	class Program
	{
		static void Main()
		{

			Dog dog = new Dog();
			dog.Run();
			dog.Eat();

			Cat cat = new Cat("Tom");
			cat.Eat();
			cat.Run();

			Console.ReadKey(true);
		}
	}
	/* Output
	 * Dog is running fast
	 * Dog is eating
	 * Tom is eating
	 * Tom is running fast
	 */
}





