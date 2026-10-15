using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7
{
	internal static class ArrayHelper
	{

		//		•  PrintReverse<T> 
		//•	დაბეჭდოს მასივის ელემენტები უკუღმა, ბოლო ელემენტიდან პირველამდე.

		//ჯენერიკი 
		// this - extension method

		public static void Print<T>(this T[] arr)
		{
		
			foreach (var item in arr)
			{
				Console.WriteLine(item);
			}
		}



		public static void PrintReverse<T>(this T[]arr)
		{
			Array.Reverse(arr);
			foreach (var item in arr)
			{
				Console.WriteLine(item);
			}
		}


//		•  GetFirstElement<T> 
//•	დააბრუნოს მასივის პირველი ელემენტი.

		public static T GetFirstElement<T>(this T[] arr)
		{
			return arr[0];
		}


		//public static void PrintUpper(this string name)
		//{
		//	Console.WriteLine(name.ToUpper());
		//}


		//		•  GetLastElement<T> 
		//•	დააბრუნოს მასივის ბოლო ელემენტი..


		public static T GetLastElement<T>(this T[] arr)
		{
			return arr[arr.Length-1];
		}


//		•  ContainsElement<T> 
//•	შეამოწმოს, შეიცავს თუ არა მასივი გადაცემულ მნიშვნელობას და დააბრუნოს true ან false. 


		public static bool ContainsElement<T>(this T[]arr, T value )
		{
			return arr.Contains(value);
		}



//		•  CountElements<T> 
//•	დააბრუნოს მასივში არსებული ელემენტების რაოდენობა(Length-ის გამოყენების გარეშე). 


		public static int CountElements<T>(this T[] arr)
		{
			//return arr.Length;
			int count = 0;
			foreach (var item in arr)
			{
				count++;
			}

			return count;
		}



//		•  FindIndex<T> 
//•	მოძებნოს გადაცემული ელემენტის ინდექსი.თუ ვერ იპოვა, დააბრუნოს -1. 


		public static int FindIndex<T>(this T[] arr, T value)
		{


			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i].Equals(value))
				{
					return i;
				}
			}


			return -1;


		}



	}
}
