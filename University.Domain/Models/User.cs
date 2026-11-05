using System;
using System.Collections.Generic;
using System.Text;

namespace University.Domain.Models
{
	public class User
	{
		public int Id { get; set; }
		public string UserName { get; set; }
		public string Email { get; set; }
		public string Password { get; set; } ///  დაშიფრული
		public string VerificattionCode { get; set; }
		public bool IsVerified { get; set; } = false;

		public override string? ToString()
		{
			return $"{Id}|{UserName}|{Email}|{Password}|{VerificattionCode}|{IsVerified}";
		}
	}
}
