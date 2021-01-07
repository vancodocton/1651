using System;

namespace Lab00ObjectsAndClasses
{
	class RandomizeWords
	{
		public void Run()
		{
			// Enter the sentences
			var sentence = Console.ReadLine();

			// Split words in the entered sentence
			var words = sentence.Split(null as char[], StringSplitOptions.RemoveEmptyEntries);

			// Random the order of words in sentences
			var random = new Random();

			for (int i = 0; i < words.Length; i++)
			{
				Swap(ref words[i], ref words[random.Next(0, words.Length)]);
			}

			// Print output
			foreach (var word in words)
			{
				Console.WriteLine(word);
			}
		}
		private void Swap(ref string s1, ref string s2)
		{
			string tmp = s1;
			s1 = s2;
			s2 = tmp;
		}
	}
}
