using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3.Models
{
	internal class Dierctor : Person
	{
		public int YearExperienceOfDirectiong { get; set; }

		public override void Work()
		{
			Console.WriteLine("Dierctor is working");
		}
	}
}
