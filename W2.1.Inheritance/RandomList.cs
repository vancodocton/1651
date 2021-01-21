using System;
using System.Collections.Generic;

namespace W2._1.Inheritance
{
	public class RandomList : List<string>
	{
		private readonly Random random = new Random();
		public string RemoveRandomElement()
		{
			int index = random.Next(0, this.Count);
			string str = this[index];
			this.RemoveAt(index);
			return str;
		}
	}
}
