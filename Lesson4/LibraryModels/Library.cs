using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson4.LibraryModels
{
	internal class Library
	{
		public string Name { get; set; }
		public int Year { get; set; }

		public Book[] Books { get; set; }   // []
		public List<Client> Clients { get; set; }
		public Manager Manager { get; set; }

		public string[] Addresses { get; set; } // ["","",]




		public void DisplayInfo()
		{
			Console.Write($"{Name}, {Year}, {Manager} ");
			foreach (var item in Addresses)
			{
				Console.Write(item + " ");
			}
			foreach (var item in Clients)
			{
				Console.Write(item);
			}
			foreach (var item in Books)
			{
				Console.Write(item);
			}

			Console.WriteLine();
		}
	}
}
