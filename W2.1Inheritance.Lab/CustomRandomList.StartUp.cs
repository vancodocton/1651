using System;
using System.Collections.Generic;

namespace CustomRandomList
{
	public class StartUp
	{
		public class RandomList : List<string>
		{
			private readonly Random random = new Random();
			public string RandomString()
			{
				int index = random.Next(0, this.Count);

				string str = this[index];
				this.RemoveAt(index);

				return str;
			}
		}
	}
}
