using System;
using System.Linq;

namespace Telephony
{
	public class StartUp
	{
		public static void Run()
		{
			// Read phone numbers and website urls
			var numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
			var urls = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

			var smartPhone = new SmartPhone();
			var stationaryPhone = new StationaryPhone();

			foreach (var number in numbers)
			{
				if (!IsValidNumber(number))
				{
					Console.WriteLine("Invalid number!");
					continue;
				}
				// Call or dial number
				switch (number.Length)
				{
					case 10:
						smartPhone.Call(number);
						break;
					case 7:
						stationaryPhone.Dial(number);
						break;
					default:
						Console.WriteLine("Invalid number!");
						break;
				}
			}

			foreach (var url in urls)
			{
				// Validate URL
				if (!IsValidURL(url))
				{
					Console.WriteLine("Invalid URL!");
					continue;
				}

				smartPhone.Browse(url);
			}
		}
		private static bool IsValidURL(string url)
		{
			for (char c = '0'; c <= '9'; c++)
			{
				if (url.Contains(c))
					return false;
			}
			return true;
		}
		private static bool IsValidNumber(string number)
		{
			string digits = "0123456789";

			foreach (char digit in number)
			{
				if (digits.Contains(digit))
					continue;
				else
					return false;
			}
			return true;
		}
	}
}
