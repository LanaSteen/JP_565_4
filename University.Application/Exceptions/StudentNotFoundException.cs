using System;
using System.Collections.Generic;
using System.Text;

namespace University.Application.Exceptions
{
	public class StudentNotFoundException : Exception
	{
	

		public StudentNotFoundException() : base("Student not found.")
		{
		}

		public StudentNotFoundException(string message) : base(message)
		{
		}
	}
}
