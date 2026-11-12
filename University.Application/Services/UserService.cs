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
		private readonly EmailService _emailService;

		public UserService(IUserRepository userRepository, EmailService emailService	)
		{
			_userRepository = userRepository;
			_emailService = emailService;
		}

		public void RegisterUser(string userName, string email, string password, string role)
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
			string code = random.Next(1000, 9999).ToString();

			var user = new User
			{
				Id = maxId,
				UserName = userName,
				Email = email,
				Password = BCrypt.Net.BCrypt.HashPassword(password),
				VerificattionCode = code,
				IsVerified = false,
				Role = role	
			};
			_userRepository.SaveUser(user);
			_emailService.SendVerificationCode(email, code);
		}


		/// verification method 
		/// IsVerified = true


		public void Verify(string email, string verificationCode)
		{
			List<string> newUserList = new List<string>();
			User user = _userRepository.GetUserByEmail(email);
			if(user.VerificattionCode == verificationCode)
			{
				var users = _userRepository.GetAllUsers();

				foreach (var item in users)
				{
					if(item.Email == email)
					{
						item.IsVerified = true;
					}

					newUserList.Add(item.ToString());
				}

				_userRepository.DeleteAllUsers();
				_userRepository.SaveUsers(newUserList);

				// file გავასაფთაო
				// დავამატო ახალი სია
			}
		}


		public User LoginUser(string email, string password)
		{
			var user = _userRepository.GetUserByEmail(email);
			                             
			if (user != null && BCrypt.Net.BCrypt.Verify(password, user.Password))
			{
				Console.WriteLine("Login successful!");
				// Perform further actions after successful login
				return user;
			}
			throw new UnauthorizedAccessException("Invalid email or password.");
		}

	}
}



