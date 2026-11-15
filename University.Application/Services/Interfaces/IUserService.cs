using System;
using System.Collections.Generic;
using System.Text;
using University.Domain.Models;

namespace University.Application.Services.Interfaces
{
	public interface IUserService
	{
		Task RegisterUser(string userName, string email, string password, string role);
		Task Verify(string email, string verificationCode);
		Task<User> LoginUser(string email, string password);

	}
}
