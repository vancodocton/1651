using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			var students = new List<Student>();

			students.Add(new Student("Truong", 19));
			students.Add(new Student("Thien", 18));
			students.Add(new Student("Lam", 20));

			foreach (var student in students)
				Console.WriteLine(student);
			students.Sort(new Student.SortNameAscending());

			foreach (var student in students)
				Console.WriteLine(student);

			Console.ReadKey(true);
		}

	}
}
