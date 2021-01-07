using System;
using System.Globalization;

namespace Lab00ObjectsAndClasses
{
	class DayOfWeek
	{
		public void Run()
		{
			// Enter date time
			var dateString = Console.ReadLine();

			// convert raw date time to the suitable format
			CultureInfo provider = CultureInfo.CurrentCulture;
			var datetime = DateTime.ParseExact(dateString, "dd-MM-yyyy", provider);

			// Print the resultss
			Console.WriteLine(datetime.DayOfWeek);
		}
	}
}
