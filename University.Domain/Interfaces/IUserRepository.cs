using System;
using System.Collections.Generic;
using System.Text;
using University.Domain.Models;

namespace University.Domain.Interfaces
{
	public interface IUserRepository
	{
		Task SaveUser(User user);
		Task<User> GetUserByEmail(string email);
		Task<List<User>> GetAllUsers();
	    Task DeleteAllUsers();
		Task SaveUsers(List<string> users);

	}
}
