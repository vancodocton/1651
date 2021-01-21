using System;

namespace W2._1.Inheritance
{
	class Program
	{
		static void Main(string[] args)
		{
			RandomList randomList = new RandomList();

			for (int i = 0; i < 10; i++)
			{
				randomList.Add(i.ToString());
			}

			Console.WriteLine(randomList.RemoveRandomElement());
			Console.WriteLine(randomList.RemoveRandomElement());

			Console.ReadKey(true);
		}
	}
}
