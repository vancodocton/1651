using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2ClassMethod
{
	class Program
	{
		static void Main()
		{
			Student student = new Student();

			student.Input();
			student.DisplayInformation();

			Console.ReadKey(true);
		}
	}
}
