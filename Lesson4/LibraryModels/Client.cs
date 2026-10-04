using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson4.LibraryModels
{
	internal class Client  : Person
	{

		public void BorrowBook(Book book) { }

		public override string? ToString()
		{
			return $"{Name} {Age} ";
		}
	}
}
