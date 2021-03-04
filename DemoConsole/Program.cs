using System;

namespace DemoConsole
{
	class Program
	{
		static void Main()
		{
			Person person = new Person(184424499, "Duong Truong", 19);
			Console.WriteLine("Before modify name");
			Console.WriteLine("Name: " + person.Name);

			// Raise error
			// person.Name = "Nguyen Ky Duong Truong";
			// person.name = "Nguyen Ky Duong Truong";
			person.ModifyName("Nguyen Ky Duong Truong");

			Console.WriteLine("After modify name");
			Console.WriteLine(person);
			Console.ReadKey(true);
		}
	}
	/* Output
	 * Before modify name
	 * Name: Duong Truong
	 * After modify name
	 * ID: 184424499, Name: Nguyen Ky Duong Truong, Age: 19
	 */
}





