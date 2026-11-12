using System;
using System.Collections.Generic;
using System.Text;
using University.Domain.Models;

namespace University.Application.Services.Interfaces
{
	public interface IUserService
	{
		void RegisterUser(string userName, string email, string password, string role);
		void Verify(string email, string verificationCode);
		User LoginUser(string email, string password);

	}
}
