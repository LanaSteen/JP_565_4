using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7
{
	internal static class CollectionHelper
	{

		//public static void Print<T>(this ICollection<T> arr)
		//{

		//	foreach (var item in arr)
		//	{
		//		Console.WriteLine(item);
		//	}
		//}

		public static void Print<T>(this IEnumerable<T> arr)
		{

			foreach (var item in arr)
			{
				Console.WriteLine(item);
			}
		}



		public static void PrintReverse<T>(this IEnumerable<T> arr)
		{
			arr.Reverse();
			foreach (var item in arr)
			{
				Console.WriteLine(item);
			}
		}



		public static int CountElements<T>(this ICollection<T> arr)
		{
			//return arr.Length;
			int count = 0;
			foreach (var item in arr)
			{
				count++;
			}

			return count;
		}


		public static int FindIndex<T>(this ICollection<T> arr, T value)
		{
			int index = 0;

			foreach (var item in arr)
			{
				if(item.Equals(value))
				{
					return index;
				}

				index++;
			}

			return -1;


		}
	}
}
