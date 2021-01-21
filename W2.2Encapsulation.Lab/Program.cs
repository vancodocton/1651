using PersonsInfo;
using System;

namespace W2._2Encapsulation.Lab
{
	class Program
	{
		static void Main()
		{
			//var app = new SortPersonsByNameAndAge();
			//var app = new SalaryIncrease();
			//var app = new ValidationOfData();
			var app = new FirstAndReserveTeam();

			app.Run();

			Console.ReadKey(true);
		}
	}
}
