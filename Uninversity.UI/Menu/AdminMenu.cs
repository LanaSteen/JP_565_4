using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Text;
using University.Application.Exceptions;
using University.Application.Services.Implemetations;

namespace Uninversity.UI.Menu
{
	public class AdminMenu
	{

		private readonly StudentService _studentService;

		public AdminMenu(StudentService studentService)
		{
			_studentService = studentService;
		}

		public void ShowMenu()
		{
			string choice = "";
			while (choice !="0")
			{
				Console.WriteLine("1. Show All Students");
				Console.WriteLine("2. Show Student By Id");
				Console.WriteLine("3. Register Student");
				Console.WriteLine("4. Update Student");
				Console.WriteLine("5. Delete All Students");
				Console.WriteLine("6. Delete Student By Id");
				Console.WriteLine("0. Exit");
				 choice = Console.ReadLine();
				switch (choice)
				{
					case "1":
						GetStudents();
						break;
					case "2":
						GetStudentById();
						break;
					case "3":
						RegisterStudent();
						break;
					case "4":
						UpdateStudent();
						break;
					case "5":
						DeleteAllStudents();
						break;
					case "6":
						DeleteStudentById();
						break;
					case "0":
						Console.WriteLine("Exiting...");
						return;
					default:
						Console.WriteLine("Invalid choice. Please try again.");
						break;
				}
			}
		}




		private void RegisterStudent()
		{
			Console.WriteLine("Enter Student Name:");
			string name = Console.ReadLine();
			Console.WriteLine("Enter Student Age:");
			int age = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter Student Grade:");
			string grade = Console.ReadLine();
			var student = new University.Domain.Models.Student
			{
				Name = name,
				Age = age,
				Grade = grade
			};
			_studentService.RegisterStudent(student);
		}


		private void UpdateStudent()
		{
			Console.WriteLine("Enter Student ID to update:");
			int id = int.Parse(Console.ReadLine());
			var student = _studentService.GetStudentById(id);
			if (student == null)
			{
				throw new StudentNotFoundException($"Student with ID {id} not found.");
			}
			Console.WriteLine($"Current Name: {student.Name}, Age: {student.Age}, Grade: {student.Grade}");
			Console.WriteLine("Enter new Name (leave blank to keep current):");
			string name = Console.ReadLine();
			Console.WriteLine("Enter new Age (leave blank to keep current):");
			string ageInput = Console.ReadLine();
			Console.WriteLine("Enter new Grade (leave blank to keep current):");
			string grade = Console.ReadLine();
			if (!string.IsNullOrWhiteSpace(name))
				student.Name = name;
			if (!string.IsNullOrWhiteSpace(ageInput) && int.TryParse(ageInput, out int age))
				student.Age = age;
			if (!string.IsNullOrWhiteSpace(grade))
				student.Grade = grade;
			_studentService.UpdateStudent(student);

		}



		private void GetStudentById()
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
	
	
	    private void GetStudents()
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

		private void DeleteAllStudents()
		{
			_studentService.DeleteAllStudents();
			Console.WriteLine("All students have been deleted.");
		}

		private void DeleteStudentById()
		{
			Console.WriteLine("Enter Student ID to delete:");
			int id = int.Parse(Console.ReadLine());
			_studentService.DeleteStudentById(id);
			Console.WriteLine($"Student with ID {id} has been deleted.");
		}
	}
}
