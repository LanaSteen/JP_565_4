using System;
using System.Collections.Generic;
using System.Text;

//this - extension method

//delegate
// Predicate -> bool
// Func -> return type
// Actiion	-> void


namespace Lesson9
{
	internal static class CollectionHelper
	{

		//public static void Print<T>(this IEnumerable<T> collection)
		//{
		//	foreach (var item in collection)
		//	{
		//		Console.WriteLine(item);
		//	}
		//}
		//public static void PrintByLogic<T>(this IEnumerable<T> collection, Predicate<T> pred)
		//{
		//	foreach (var item in collection)
		//	{

		//		if (pred(item))
		//		{
		//			Console.WriteLine(item);
		//		}
		
		//	}
		//}

		//public static void PrintByLogic1<T>(this IEnumerable<T> collection, Func<T, bool> pred)
		//{
		//	foreach (var item in collection)
		//	{

		//		if (pred(item))
		//		{
		//			Console.WriteLine(item);
		//		}

		//	}
		//}


		//public static void PrintByLogic3<T>(this IEnumerable<T> collection, Func<T, T> pred)
		//{
		//	foreach (var item in collection)
		//	{
		//		var result = pred(item);

		//		Console.WriteLine(result);
				

		//	}
		//}


		//public static void PrintByLogic4<T, T1>(this IEnumerable<T> collection, Func<T, T1> pred)
		//{
		//	foreach (var item in collection)
		//	{
		//		var result = pred(item);

		//		Console.WriteLine(result);
		//	}
		//}



		//public static bool CustomAny<T>(this IEnumerable<T> col, Predicate<T> pred)
		//{
		//	foreach (var item in col)
		//	{
		//		if (pred(item))
		//		{
		//			return true;
		//		}
		//	}

		//	return false;
		//}



		//public static bool CustomAll<T>(this IEnumerable<T> col, Predicate<T> pred)
		//{
		//	foreach (var item in col)
		//	{
		//		if (!pred(item))
		//		{
		//			return false;
		//		}
		//	}

		//	return true;
		//}



		//public static int CustomCount<T>(this IEnumerable<T> col, Predicate<T> pred = null)
		//{

		//	if (pred == null)
		//	{
		//		return col.Count();
		//	}
		//	else
		//	{
		//		int count = 0;
		//		foreach (var item in col)
		//		{
		//			if (pred(item))
		//			{
		//				count++;
		//			}
		//		}

		//		return count;
		//	}

		//}


		//LastOrDefault აბრუნებს ბოლო   ელემენტს, რომელიც შეესაბამება პირობას.
		//ხოლო თუ ვერ იპოვა — აბრუნებს default მნიშვნელობას (null, 0, false და ა.შ.).




	}
}


