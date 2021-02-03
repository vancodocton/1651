using System;

namespace DemoConsole
{
	class Program
	{
		static void Main()
		{
			// declare objects
			Person person1 = new Person("Nguyen Ky Duong Truong", 19);
			Person person2 = new Person("Pham Duc Thien", 19);

			// call object's method
			person1.Greet();
			person2.Greet();

			Console.ReadKey(true);
		}
	}
}
