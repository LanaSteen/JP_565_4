using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9
{
	internal class Student
	{

		public string Name { get; set; }

		public int Age { get; set; }
		public int Grade { get; set; }

		public override string? ToString()
		{
			return $"{Name}, {Age}, {Grade}";
		}
	}
}
