using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2ClassMethod
{
	class Student : Person
	{
		private double gpa;
		public double Gpa { get => gpa; private set => gpa = value; }

		public Student(string name1, int age1, double gpa1)
		{
			Age = age1;
			gpa = gpa1;
			Name = name1;
		}
		public Student()
		{
		}
		public void DisplayInformation()
		{
			DisplayPerson();
			Console.WriteLine($"GPA: \t{gpa}");
		}
		public override void Input()
		{
			base.Input();
			Console.Write("Please input GPA: ");
			gpa = double.Parse(Console.ReadLine());
		}
	}
}
