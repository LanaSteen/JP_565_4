using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2.Models
{
	public class User  
	{
		//oop - polymorphism  --  many forms  --same method name but different parameters or same method name and same parameters but different implementation

		///  გადატვირთვა ოვერლოადი -- overload  --  same method name but different parameters


		//  oop - incapsulation  --  data hiding  --  private fields and public properties
		//  full property  --  private field and public property with get and set

		// გადაფარვა / გადაწერა -- override  --  same method name and same parameters but different implementation  abstract or virtual


		public User(string userName, int birthYear)
		{
			UserName = userName;
			BirthYear = birthYear;
		}

		public User(string userName)
		{
			UserName = userName;
		}
		public User(int birthYear)
		{
			BirthYear = birthYear;
		}

		public User()
		{
		}

		// properties  -- მახასიათებლები 
		// methods  -- მეთოდები
		// constructors  -- კონსტრუქტორები

		// feilds  -- ველები --
		// full property   -- 


		private int _age;   //20
		public int Age
		{
			get
			{
				return _age;
			}
			set
			{
				if (value < 0)
				{
					Console.WriteLine("Age can not be negative");
				}
				else
				{
					_age = value;
				}

			}

		}

		public string UserName { get; set; }

		public int BirthYear { get; set; }



		private string _email;

		public string Email
		{
			get { return _email; }
			set
			{

				if (value.Contains("@"))
				{
					_email = value;
				}
				else
				{
					Console.WriteLine("Invalid email format");
				}

			}
		}





		public int GetAge()
		{
			return DateTime.Now.Year - BirthYear;
		}


		public void PrintUserName()
		{
			Console.WriteLine(UserName);
		}

		public static void Test()
		{
			Console.WriteLine("rame");
		}

		public static void Test(string text)
		{
			Console.WriteLine(text);
		}



		//public void DisplayInfo()
		//{
		//	Console.WriteLine($"UserName: {UserName}, BirthYear: {BirthYear}, Age: {GetAge()}");
		//}

		public override string? ToString()
		{
			return $"UserName: {UserName}, BirthYear: {BirthYear}, Age: {GetAge()}";
		}

		public override bool Equals(object? obj)
		{
			if (obj is User other)
			{
				return UserName == other.UserName && BirthYear == other.BirthYear;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return  this.UserName.GetHashCode();
		}
	}

}





