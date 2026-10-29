using University.Application.Services;
using University.Domain.Interfaces;
using University.Domain.Models;
using University.Infrastructure;

namespace Uninversity.UI
{
	internal class Program
	{
		static void Main(string[] args)
		{



			IStudetnRepository studetnRepository = new	StudetnRepository();

			StudentService studentService = new StudentService(studetnRepository);

		


			studentService.RegisterStudent(new Student { Id = 1, Name = "John Doe", Age = 20, Grade = "A" });



			var students = studentService.GetAllStudents();
			foreach (var student in students)
			{
				Console.WriteLine(student);
			}
		}
	}
}
