using System;
using System.Collections.Generic;
using System.Text;
using University.Domain.Interfaces;
using University.Domain.Models;

namespace University.Infrastructure
{
	internal class UserTestReoisutory : IUserRepository
	{
		private readonly string _path = @"C:\Users\l4nst\Desktop\JP_565_4 online\University.Infrastructure\Data\USerTest.txt";

		

		Task IUserRepository.DeleteAllUsers()
		{
			throw new NotImplementedException();
		}

		Task<List<User>> IUserRepository.GetAllUsers()
		{
			throw new NotImplementedException();
		}

		Task<User> IUserRepository.GetUserByEmail(string email)
		{
			throw new NotImplementedException();
		}

		Task IUserRepository.SaveUser(User user)
		{
			throw new NotImplementedException();
		}

		Task IUserRepository.SaveUsers(List<string> users)
		{
			throw new NotImplementedException();
		}
	}
}
