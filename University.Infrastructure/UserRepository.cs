using System;
using System.Collections.Generic;
using System.Text;
using University.Domain.Interfaces;
using University.Domain.Models;

namespace University.Infrastructure
{
	public class UserRepository : IUserRepository
	{
		private readonly string _path = @"C:\Users\l4nst\Desktop\JP_565_4 online\University.Infrastructure\Data\User.txt";

		public void SaveUser(User user)
		{
			File.AppendAllLines(_path, new List<string> { user.ToString() });
		}

		public User GetUserByEmail(string email)
		{
			var userLines = File.ReadAllLines(_path).ToList();
			foreach (var line in userLines)
			{
				var parts = line.Split('|');
				if (parts[2] == email)
				{
					User user = new User();
					// Assuming User class has properties Id, UserName, Email, and Password
					user.Id = int.Parse(parts[0]);
					user.UserName = parts[1];
					user.Email = parts[2];
					user.Password = parts[3];
					return user;
				}
			}
			return null;
		}


		public List<User> GetAllUsers()
		{
			var userLines = File.ReadAllLines(_path).ToList();
			List<User> userList = new List<User>();
			foreach (var line in userLines)
			{
				var parts = line.Split('|');
				User user = new User();
				user.Id = int.Parse(parts[0]);
				user.UserName = parts[1];
				user.Email = parts[2];
				user.Password = parts[3];
				userList.Add(user);
			}
			return userList;
		}
	}
}