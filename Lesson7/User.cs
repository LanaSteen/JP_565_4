using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7
{
	internal class User 
	{
		public string Name { get; set; }
		public string Password { get; set; }

		public override bool Equals(object? value)
		{
			return Name == ((User)value).Name && Password == ((User)value).Password;
		}

		public override string? ToString()
		{
			return $"Name: {Name}, Password: {Password}";
		}
	}
}
