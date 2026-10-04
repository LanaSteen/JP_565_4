using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson4.LibraryModels
{
	internal class Manager : Person
	{
		public override string? ToString()
		{
			return $"{Name} {Age} ";
		}
		public void AddBook(Book book) { }
	}
}
