using System;
using System.Collections.Generic;
using System.Text;
using University.Domain.Interfaces;
using University.Domain.Models;

namespace University.Application.Services
{
	public class UserService
	{

		//DI   

		private readonly IUserRepository _userRepository;

		public UserService(IUserRepository userRepository)
		{
			_userRepository = userRepository;
		}

		public void RegisterUser(string userName, string email, string password)
		{
	
			List<User> users = _userRepository.GetAllUsers();

			int maxId = 0;
			if(users.Count > 0)
			{
				maxId = users.Max(u => u.Id);
				maxId++;
			}
			// getAll
			Random random = new();


			var user = new User
			{
				Id = maxId,
				UserName = userName,
				Email = email,
				Password = BCrypt.Net.BCrypt.HashPassword(password),
				VerificattionCode = random.Next(1000, 9999).ToString(),
				IsVerified = false
			};
			_userRepository.SaveUser(user);
		}


		/// verification method 
		/// IsVerified = true



		public void LoginUser(string email, string password)
		{
			var user = _userRepository.GetUserByEmail(email);
			                             
			if (user != null && BCrypt.Net.BCrypt.Verify(password, user.Password))
			{
				Console.WriteLine("Login successful!");
				// Perform further actions after successful login
			}
			else
			{
				Console.WriteLine("Invalid email or password.");
			}
		}

	}
}



