using System;
using System.Collections.Generic;
using System.Text;

namespace University.Domain.Models
{
	public class Student
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Age { get; set; }
		public string Grade { get; set; }
		public override string ToString()
		{
			return $"{Id}|{Name}|{Age}|{Grade}";
		}
	}
}
