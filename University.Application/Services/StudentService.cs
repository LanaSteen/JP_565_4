using System;
using System.Collections.Generic;
using System.Text;
using University.Domain.Interfaces;
using University.Domain.Models;

namespace University.Application.Services
{
	public class StudentService
	{
		private IStudetnRepository _studentRepository;

		public StudentService(IStudetnRepository studentRepository)
		{
			_studentRepository = studentRepository;
		}


		


		public void RegisterStudent(Student student)
		{
			if(student == null)
			{
				Console.WriteLine("Student cannot be null.");
			}
			if(student.Age < 0)
			{
				Console.WriteLine("Student age cannot be negative.");
			}

			_studentRepository.SaveStudent(student);



		}
		public List<Student> GetAllStudents()
		{
			var studentList = _studentRepository.GetAllStudents();
			if(studentList == null || studentList.Count == 0)
			{
				Console.WriteLine("No students found.");
			}
			return _studentRepository.GetAllStudents();
		}
	}
}
