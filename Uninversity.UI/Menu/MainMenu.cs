using System;
using System.Collections.Generic;
using System.Text;
using University.Application.Services;

namespace Uninversity.UI.Menu
{
	public class MainMenu
	{

		//DI
		private readonly UserService _service;

		public MainMenu(UserService service)
		{
			_service = service;
		}


		public void ShowMenu()
		{
			Console.WriteLine("1. Register");
			Console.WriteLine("2. Login");
			Console.WriteLine("0. Exit");
			string choice = Console.ReadLine();
			switch (choice)
			{
				case "1":
					RegisterUser();
					break;
				case "2":
					LoginUser();
					break;
				case "0":
					Console.WriteLine("Exiting...");
					break;
				default:
					Console.WriteLine("Invalid choice. Please try again.");
					ShowMenu();
					break;
			}
		}

		public void RegisterUser()
		{
			Console.WriteLine("Enter UserName");
			string userName = Console.ReadLine();
			Console.WriteLine("Enter Email");
			string email = Console.ReadLine();
			Console.WriteLine("Enter Password");
			string password = Console.ReadLine();

			//service.RegisterUser();
			_service.RegisterUser(userName, email, password);

		}

		public void LoginUser()
		{
			Console.WriteLine("Enter Email");
			string email = Console.ReadLine();
			Console.WriteLine("Enter Password");
			string password = Console.ReadLine();

			_service.LoginUser(email, password);


		}

		// რეგისტრაცია
		// ლოგინი
		// ვერფიკაცია
	}
}
