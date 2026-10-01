using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3.Models
{
	internal abstract class Person
	{
		public string FIrstName { get; set; }
		public int Age { get; set; }


		public virtual void GetInfo()  // ოფშენალია ოვერრაიდი
		{
			Console.WriteLine($"My name is {FIrstName} and I am {Age} years old");
		}


		public abstract void Work(); // სავალდებულოა ოვერრაიდი


		//virtual 
		//abstract
	}
}


//oop - პოლიმომრფიზმი

//  ovverride
//	overload



//  1. მემკვიდრეობა
//	2. ინკაფსულაცია
//	3. პოლიმორფიზმი
//	4. აბსტრაქცია



