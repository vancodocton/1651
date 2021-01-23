using System;

namespace Telephony
{
	class SmartPhone : ISmartphone
	{
		public void Browse(string url)
		{
			Console.WriteLine($"Browsing: {url}!");
		}
		public void Call(string number)
		{
			Console.WriteLine($"Calling... {number}");
		}
	}
}
