using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole
{
	class Student : IComparable<Student>
	{
		public string Name { get; protected set; }
		public int Age { get; protected set; }

		public Student(string name, int age)
		{
			Name = name;
			Age = age;
		}

		public override string ToString()
		{
			return $"Name: {Name}, Age: {Age}";
		}

		public int CompareTo(Student other) => Age.CompareTo(other.Age) * -1;

		public class SortNameAscending : IComparer<Student>
		{
			public int Compare(Student student1, Student student2)
			{
				return student1.Name.CompareTo(student2.Name) * -1;
			}
		}
	}
}
