using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csReview
{
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
