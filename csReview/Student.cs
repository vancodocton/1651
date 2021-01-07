using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csReview
{
	class Student
	{
		public int Age { get; private set; }
		public float Gpa { get; private set; }
		public string Name { get; private set; }

		public Student(int age, float gpa, string name)
		{
			Age = age;
			Gpa = gpa;
			Name = name;
		}
		public void DisplayInformation()
		{
			Console.WriteLine($"Student name: \t{Name}");
			Console.WriteLine($"Student age: \t{Age}");
			Console.WriteLine($"Student GPA: \t{Gpa}");
		}
		public override string ToString()
		{
			return base.ToString();
		}
	}
}
