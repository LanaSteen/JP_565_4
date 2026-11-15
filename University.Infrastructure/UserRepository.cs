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

		public async Task SaveUser(User user)
		{
		  await	File.AppendAllLinesAsync(_path, new List<string> { user.ToString() });
		}

		public async Task SaveUsers(List<string> users)
		{
			await File.AppendAllLinesAsync(_path, users);
		}

		public async Task DeleteAllUsers()
		{
			await File.WriteAllTextAsync(_path,""); /// შეიცვალა writeშ
		}
		public async Task<User> GetUserByEmail(string email)
		{
			var userLines = await File.ReadAllLinesAsync(_path);
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
					user.VerificattionCode = parts[4];
					user.IsVerified = bool.Parse(parts[5]);
					user.Role = Enum.Parse<UserRole>(parts[6]);
					return user;
				}
			}
			return null;
		}



		public async Task<List<User>> GetAllUsers()
		{
			var userLines = await File.ReadAllLinesAsync(_path);
			List<User> userList = new List<User>();
			foreach (var line in userLines)
			{
				var parts = line.Split('|');
				User user = new User();
				user.Id = int.Parse(parts[0]);
				user.UserName = parts[1];
				user.Email = parts[2];
				user.Password = parts[3];
				user.VerificattionCode = parts[4];
				user.IsVerified = bool.Parse( parts[5]);
				user.Role = Enum.Parse<UserRole>(parts[6]);

				userList.Add(user);
			}
			return userList;
		}
	}
}