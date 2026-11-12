using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Text;
using University.Application.Services.Implemetations;
using University.Application.Services.Interfaces;

namespace Uninversity.UI.Menu
{
	public class MainMenu
	{

		//DI
		private readonly IUserService _service;
		private readonly StudentService _studentService;

		public MainMenu(IUserService service, StudentService studentService	)
		{
			_service = service;
			_studentService = studentService;
		}


		public void ShowMenu()
		{
			//Console.WriteLine("1. Register");
			//Console.WriteLine("2. Login");
			//Console.WriteLine("3. Verify");
			//Console.WriteLine("0. Exit");

			var choice = AnsiConsole.Prompt(
				new SelectionPrompt<string>()
				.Title("1. Register, 2. Login, 3. Verify, 0. Exit")
				.AddChoices("1. Register", "2. Login", "3. Verify", "0. Exit"));


			//string choice = Console.ReadLine();
			switch (choice)
			{
				case "1. Register":
					RegisterUser();
					break;
				case "2. Login":
					LoginUser();
					break;
				case "3. Verify":
					VerifyUser();
					break;
				case "0. Exit":
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


			// masking password input  specre.console-
			var password = new TextPrompt<string>("Enter your [green]password[/]:").Secret();
			var passwordResult = AnsiConsole.Prompt(password);

			//Console.WriteLine("Enter Password");
			//string password = Console.ReadLine();




			Console.WriteLine("Enter Role");
			string role = Console.ReadLine();

			//service.RegisterUser();
			_service.RegisterUser(userName, email, passwordResult, role);

		}

		public void LoginUser() // todo dont allow login if not verified
		{
			Console.WriteLine("Enter Email");
			string email = Console.ReadLine();
			Console.WriteLine("Enter Password");
			string password = Console.ReadLine();

		  	var user =_service.LoginUser(email, password);

			if(user.Role == "Admin")
			{
				AdminMenu adm = new AdminMenu(_studentService);
				adm.ShowMenu();
			}
			else
			{
				UserMenu usm = new UserMenu(_studentService);
				usm.ShowMenu();
			}



			//// if admin show admin menu
			/// else show user menu

		}


		public void VerifyUser()
		{
			Console.WriteLine("Enter Email");
			string email = Console.ReadLine();
			Console.WriteLine("Enter Verification Code");
			string verificationCode = Console.ReadLine();
			_service.Verify(email, verificationCode);
		}

		// რეგისტრაცია
		// ლოგინი
		// ვერფიკაცია
	}
}
