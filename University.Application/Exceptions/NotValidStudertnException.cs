using System;
using System.Collections.Generic;
using System.Text;

namespace University.Application.Exceptions
{
	public class NotValidStudertnException : Exception
	{
		const string DefaultMessage = "The student is not valid.";
		public NotValidStudertnException() : base(DefaultMessage)
		{
		}

		public NotValidStudertnException(string message) : base(message)
		{
		}
	}
}
