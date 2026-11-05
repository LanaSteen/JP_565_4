using System;
using System.Collections.Generic;
using System.Text;
using University.Domain.Models;

namespace University.Domain.Interfaces
{
	public interface IUserRepository
	{
		void SaveUser(User user);
		User GetUserByEmail(string email);
		List<User> GetAllUsers();
	}
}
