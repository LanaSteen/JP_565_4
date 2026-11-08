using System;
using System.Collections.Generic;
using System.Text;
using University.Application.Exceptions;
using University.Application.Services;

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
			Console.WriteLine("1. Register Student");
			Console.WriteLine("2. Update Student");
			Console.WriteLine("3. Get Student by Id");
			Console.WriteLine("4. Get Students");
			Console.WriteLine("5. DELETE StudentS");
			Console.WriteLine("6. DELETE Student bY ID");
			Console.WriteLine("0. Exit");
			string choice = Console.ReadLine();
			switch (choice)
			{
				case "1":
					RegisterStudent();
					break;
				case "2":
					UpdateStudent();
					break;
				case "3":
					GetStudentById();
					break;
				case "4":
					GetStudents();
					break;
				case "5":
					DeleteAllStudents();
					break;
				case "6":
					DeleteStudentById();
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
			foreach (var student in students)
			{
				Console.WriteLine(student);
			}
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
