using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6
{
	internal static class ArrayHelper
	{
		public static void PrintArray<T>(this T[] arr)
		{
			foreach (var item in arr)
			{
				Console.WriteLine(item);
			}
		}

		public static T FindElement<T>(this T[] arr, T searchEl)
		{
			foreach (var item in arr) 
			{
				if (item.Equals(searchEl))
				{
					return item;
				}
			
			}
			return default;
		}

		//[20,60,50,60,70,60,50,60,80]
		public static T FindLastElenet<T>(this T[] arr, T searchEl)
		{

			Array.Reverse(arr);
			foreach (var item in arr)
			{
				if (item.Equals(searchEl) )
				{
					return item;
				}

			}
			return default;

		}


		///[20,60,50,60,70,60,50,60,80]    1   100 

		//[20,100,50,60,70,60,50,60,80]

		// შექმენით მეთოდი რომელიც მიიღებს მასივს , ინდექსს და ელემენტს
		//მოცემულ მასივში მოცემულ ინდექსზე შეცვლის ელემენტს მოცემული ელემენტით




		//public static void PrintArray(this string[] arr)
		//{
		//	foreach (var item in arr)
		//	{
		//		Console.WriteLine(item);
		//	}
		//}

		//public static void PrintArray(this User[] arr)
		//{
		//	foreach (var item in arr)
		//	{
		//		Console.WriteLine(item);
		//	}
		//}



	}
}


//exstention method