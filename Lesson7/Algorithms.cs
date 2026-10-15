using System;
using System.Collections.Generic;
using System.Text;


//delegate 
//	Func    // აბრუნებს კონკრეტულ მნიშვნელობას
//	Predicate  // აბრუნებს bool
//	Action  // void

namespace Lesson7
{
	internal static class Algorithms
	{

		//>50
		public static IEnumerable<T> CustomWhere<T>(this IEnumerable<T> collection, Predicate<T> predicare)
		{
			List<T> list = new List<T>();
			foreach (var item in collection)
			{
				if (predicare(item))
				{
					list.Add(item);
				}
			}


			return list;
		}


	}
}
