using System;

namespace L2ClassMethod
{
	public class Student : Person
	{
		protected double gpa;
		public double Gpa { get => gpa; }

		public Student(string name, int age, double gpa)
		{
			this.age = age;
			this.name = name;
			this.gpa = gpa;
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
		public override string ToString()
		{
			return base.ToString() + $", GPA: {gpa}";
		}
	}
}
