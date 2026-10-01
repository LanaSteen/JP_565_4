using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3.Models
{
	internal class Actor  : Person
	{
		public string Role { get; set; }

		public override void Work()
		{
			Console.WriteLine("Actor is working");
		}
	}
}
