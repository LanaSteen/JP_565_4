using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3.Models
{
	internal class Producer : Person
	{
		public string Company { get; set; }

		public override void GetInfo()
		{
			Console.WriteLine($"Producer: {FIrstName} Company: {Company}");
		}

		public override void Work()
		{
			Console.WriteLine("Producer is working");
		}
	}
}
