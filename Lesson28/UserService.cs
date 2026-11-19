using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson28
{
	internal class UserService
	{

		private List<User> _users = new List<User>() 
		{
		   new User { Id = 1, Name = "John Doe", Email = "dsds@fdfd" },
		   new User { Id = 2, Name = "Jane Smith", Email = "dsds@fdfd" },

		};


		public async Task<User> GetUserByIdAsync(int id)
		{
			await Task.Delay(1000); // Simulate some asynchronous operation
			Console.WriteLine("waiting....");
			return _users.FirstOrDefault(u => u.Id == id);
		}


		public async Task<List<User>> GetAllUsersAsync()
		{
			var user = await GetUserByIdAsync(1);
			await Task.Delay(1000); // Simulate some asynchronous operation
			return _users;
		}


		public async Task AddUserAsync(User user)
		{
			await Task.Delay(1000); // Simulate some asynchronous operation
			_users.Add(user);
		}
	}
}
