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
		public Client[] Clients { get; set; }
		public Manager Manager { get; set; }

		public string[] Addresses { get; set; } // ["","",]


	}
}
