using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3.Models
{
	internal class Car 
	{
		public string Brand { get; set; }
		public string Model { get; set; }


		private int _year; /// შემნახველი ადგილი

		public int Year  // გამტარი
		{
			get { return _year; }
			set
			{ 
			   if(value <0)
				{
					Console.WriteLine("Year is not valid");
				}
				else
				{
					_year = value;
				}
			}
		}
		

		private double _engineCapaciry;

		public double EngineCapaciry
		{
			get { return _engineCapaciry; }
			set { 
			   if(value <= 0   || value > 1000)
				{
					Console.WriteLine("Engine capacity is not valid");
				}
				else
				{
					_engineCapaciry = value;
				}
			
			}
		}


		public Color Color { get; set; } /// 'Red'



		//2026 - 5 = 2021

		public void GetCarYearInfo()
		{
			int releaseYear = DateTime.Now.Year - Year;
			Console.WriteLine($"Car was reased in {releaseYear}");
		}

		//public void GetCarInfo()
		//{
		//	Console.WriteLine($"{Brand} {Model} {Year} {EngineCapaciry} {Color}");
		//}

		public override string? ToString()
		{
			return $"{Brand} {Model} {Year} {EngineCapaciry} {Color}";
		}

	

		//დაამატეთ მეთოდები -
		//1.რომელიც გამოთვლის რომელ წელს არის მანქანა გამოშვებული
		//2.რომელიც დაბეჭდავს მანქანის ყველა მახასიათებელს.

	}
}



enum Color
{
	Red,
	Green,
	Blue,
	Yellow,
	Black,
	White,
	Other
}

//enum   ენუმერაბლი


//brand,
//model,
//year,  --
//engine capacity, 
//color