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

		public void DeleteAllUsers()
		{
			throw new NotImplementedException();
		}

		public List<User> GetAllUsers()
		{
			throw new NotImplementedException();
		}

		public User GetUserByEmail(string email)
		{
			throw new NotImplementedException();
		}

		public void SaveUser(User user)
		{
			throw new NotImplementedException();
		}

		public void SaveUsers(List<string> users)
		{
			throw new NotImplementedException();
		}
	}
}
