using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6
{
	internal class User 
	{

		public string Name { get; set; }
		public string Password { get; set; }

		public override bool Equals(object? obj)
		{
			return obj is User user && Name == user.Name && Password == user.Password;
		}


		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override string? ToString()
		{
			return $"Name: {Name} - Password {Password}";
		}
	}
}
