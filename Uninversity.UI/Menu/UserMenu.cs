using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Text;
using University.Application.Exceptions;
using University.Application.Services.Implemetations;

namespace Uninversity.UI.Menu
{
	public class UserMenu
	{

		private readonly StudentService _studentService;

		public UserMenu(StudentService studentService)
		{
			_studentService = studentService;
		}

		public void ShowMenu()
		{
			string choice = "";
			while (choice != "0")
			{
				Console.WriteLine("1. Show All Students");
				Console.WriteLine("2. Show Student By Id");
				Console.WriteLine("0. Exit");
				choice = Console.ReadLine();
				switch (choice)
				{
					case "1":
						ShowAllStudent();
						break;
					case "2":
						ShowStudentById();
						break;
						;
					case "0":
						Console.WriteLine("Exiting...");
						break;
					default:
						Console.WriteLine("Invalid choice. Please try again.");
						ShowMenu();
						break;
				}

			}
		}


		private void ShowStudentById()
		{
			Console.WriteLine("Enter Student ID:");
			int id = int.Parse(Console.ReadLine());
			var student = _studentService.GetStudentById(id);
			if (student == null)
			{
				throw new StudentNotFoundException($"Student with ID {id} not found.");

			}

			Console.WriteLine(student);
		}


		private void ShowAllStudent()
		{
			var students = _studentService.GetAllStudents();

			var table = new Table();

			// Add columns
			table.AddColumn("Id");
			table.AddColumn("Name");
			table.AddColumn("Age");
			table.AddColumn("Grade");

			foreach (var student in students)
			{
				// Add rows
				table.AddRow(student.Id.ToString(), student.Name, student.Age.ToString(), student.Grade.ToString());
			}


			AnsiConsole.Write(table);


			
		}



	}
}
