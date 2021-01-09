using System;
namespace csReview
{
	class Program
	{
		static void Main(string[] args)
		{
			//To run code of other exercise, change Exercise3 to the class representing for it


			//do
			//{
			//	Console.WriteLine(dice.Roll());
			//	//var key = Console.ReadKey(true).Key.ToString();
			//} while (Console.ReadKey(true).Key.ToString() == "Enter");

			var student = new Student("Nguyen Ky Duong Truong", 19, 8.9);
			student.DisplayInformation();
		}
	}
}
