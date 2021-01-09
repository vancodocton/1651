using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab00ObjectsAndClasses
{

	class StudentList2
	{
		public List<Student> Students { get; set; }

		public StudentList2()
		{
			Students = new List<Student>();
		}
		public void Run()
		{
			string[] raw = Console.ReadLine().Split();

			do
			{
				Add(raw);
				raw = Console.ReadLine().Split();
			}
			while (raw[0] != "end");


			string city = Console.ReadLine();
			DisplayStudentInfoFromCity(city);
		}
		public void Add(string[] raw)
		{
			Student student = new Student
			{
				FirstName = raw[0],
				LastName = raw[1],
				Age = int.Parse(raw[2]),
				HomeTown = raw[3]
			};

			for (int i = 0; i < Students.Count; i++)
			{
				if (student.FirstName == Students[i].FirstName && student.LastName == Students[i].LastName)
				{
					Students[i] = student;
					return;
				}
			}
			Students.Add(student);
		}
		public void DisplayStudentInfoFromCity(string city)
		{
			foreach (var student in Students)
			{
				if (student.HomeTown == city)
				{
					Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
				}
			}
		}
	}

}
