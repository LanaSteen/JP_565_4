using Microsoft.Extensions.Configuration;
using Spectre.Console;
using Uninversity.UI.Menu;
using University.Application.Exceptions;
using University.Application.Services.Implemetations;
using University.Application.Services.Interfaces;
using University.Domain.Interfaces;
using University.Domain.Models;
using University.Infrastructure;

namespace Uninversity.UI
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var config = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
				.Build();

			IUserRepository userRepository = new UserRepository();
			IEmailService emService = new EmailNewService();
			IEmailService emailService = new EmailService();	
			IUserService userService = new UserService(userRepository, emailService);
			StudetnRepository studentRepository = new StudetnRepository();
			StudentService studentService = new StudentService(studentRepository);
			MainMenu mainMenu = new MainMenu(userService, studentService, config);

			try
			{
				string choice = string.Empty;
				while (choice != "0")
				{

					mainMenu.ShowMenu();

				}
			}
			catch (Exception ex)
			{

				AnsiConsole.MarkupLine($"[red]Error message[/] {ex.Message} ");
			}


			#region student code


			//IStudetnRepository studetnRepository = new	StudetnRepository();

			//StudentService studentService = new StudentService(studetnRepository);



			//try
			//{

			//	studentService.RegisterStudent(new Student { Id = 1, Name = "John Doe", Age = 20, Grade = "A" });

			//}
			//catch (ArgumentException ex)
			//{
			//	Console.WriteLine(ex.Message);

			//}
			//catch (InvalidOperationException ex)
			//{
			//	Console.WriteLine(ex.Message);
			//}
			//catch (NotValidStudertnException ex)
			//{
			//	Console.WriteLine(ex.Message);
			//}
			//catch (Exception ex)
			//{

			//	Console.WriteLine(ex.Message);
			//}


			//var students = studentService.GetAllStudents();
			//foreach (var student in students)
			//{
			//	Console.WriteLine(student);
			//}


			#endregion
		}
	}
}
