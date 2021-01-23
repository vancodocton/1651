using System;

namespace Telephony
{
	class StationaryPhone : IStationaryPhone
	{
		public void Dial(string number)
		{
			Console.WriteLine($"Dialing...{number}");
		}
	}
}
