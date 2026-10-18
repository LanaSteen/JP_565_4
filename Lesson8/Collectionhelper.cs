using System;
using System.Collections.Generic;
using System.Text;

//delegate 
	//Predicate // bool
	//Func   // int,string,bool
	//Action  // void



	//arr.filter(x=> x>60)

namespace Lesson8
{
	internal static class Collectionhelper
	{

		public static void Print<T>(this IEnumerable<T> arr)
		{
			foreach (var item in arr)
			{
				Console.WriteLine(item);
			}
		}


		public static void sum(this int num1, int num2)
		{
			Console.WriteLine(num1 + num2);
		}


		//[20,30,60,75]  -- 50

		public static T CustomFind<T>(this IEnumerable<T> colllection, T el)
		{
			foreach (var item in colllection)
			{
				if (item.Equals(el))
				{
					return item; // 20
				}
			}
			return default; // 0
		}



		public static IEnumerable<T> CustomFIlter<T>(this IEnumerable<T> colllection, Predicate<T> predicate)
		{
			List<T> result = new List<T>();

			foreach (var item in colllection)
			{
				if (predicate(item)) // false
				{
					result.Add(item);
				}
			}
			
			return result;
		}


		//პირველივე ელემენტი რომელიც აკმაყოფილებს პირობას 
		// customFirstorDefault

		public static T CustomFirstorDefault<T>(this IEnumerable<T> collection, Predicate<T> pred) 
		{
		    foreach (var item in collection)
			{
				if (pred(item))	return item;
				
			}

			return default;
		}

		public static IEnumerable<T> CustomSelect<T> (this IEnumerable<T> collection, Func<T,T> convert)
		{
			List<T> list = new List<T>();
			foreach (var item in collection)
			{
				list.Add(convert(item));
			}

			return list;
		}

		public static IEnumerable<T1> CustomSelect2<T, T1>(this IEnumerable<T> collection, Func<T, T1> convert)
		{
			List<T1> list = new List<T1>();
			foreach (var item in collection)
			{
				list.Add(convert(item));
			}

			return list;
		}


	}
}
//this  // extention method