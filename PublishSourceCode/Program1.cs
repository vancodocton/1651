using System;
using System.Globalization;

namespace PublishSourceCode
{
    // class Program
    // {
    //     static void Main(string[] args)
    //     {
    //        var app = new reviewCS.Exercise1();
    //        app.Run();
    //        Console.ReadKey(true);           
    //     }
    // }
}

namespace reviewCS
{
    class Exercise1
    {
        public void Run()
        {
            Console.Write("Enter n = ");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }

            Console.WriteLine("Sum of serial number from 1 to {0} is {1}", n, sum);
        }
    }
    class Exercise2
	{
		public void Run()
		{
			int n = InputNum();

			if (CheckPrime(n))
				Console.WriteLine($"{n} is a prime");
			else
				Console.WriteLine($"{n} is not a prime");
		}

		private int InputNum()
		{
			int n;

			do
			{
				Console.Write("Enter n bigger than 1: ");
				n = int.Parse(Console.ReadLine());
			} while (n < 2);

			return n;
		}

		private bool CheckPrime(int n)
		{
			int sqrtNum = (int)Math.Sqrt(n);

			for (int i = 2; i <= sqrtNum; i++)
				if (n % i == 0)
					return false;

			return true;
		}
	}
    class Exercise3
	{
		private int Num;
		public void Run()
		{
			// Generate a random number from 1 to 100
			Random random = new Random();
			Num = random.Next(1, 100);

			Console.WriteLine("n is a number in range from 1 to 100");
			// Guessing n 7 time
			for (int i = 1; i <= 7; i++)
			{
				Console.Write($"Guessing {i} time, n = ");

				// check guessing result
				int n = int.Parse(Console.ReadLine());
				if (n == Num)
				{
					Console.WriteLine("Congratulations, You're winner!");
					return;
				}
				else
				{
					if (n < Num)
						Console.WriteLine("Opps, You're wrong! Guessed number is smaller than n");
					else
						Console.WriteLine("Opps, You're wrong! Guessed number is bigger than n");
				}
			}

			// Print n if guessing fail
			Console.WriteLine("Sorry, You're fail!");
			Console.WriteLine($"n = {Num}");
			return;
		}
	}
    class Student
	{
		private int age;
		private double gpa;
		private string name;
		public int Age { get => age; private set => age = value; }
		public double Gpa { get => gpa; private set => gpa = value; }
		public string Name { get => name; private set => name = value; }

		public Student(string name, int age, double gpa)
		{
			Age = age;
			Gpa = gpa;
			Name = name;
		}
		public void DisplayInformation()
		{
			Console.WriteLine($"Student name: \t{name}");
			Console.WriteLine($"Student age: \t{age}");
			Console.WriteLine($"Student GPA: \t{gpa}");
		}
	}
    
}

namespace Lab_ObjectsAndClasses
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