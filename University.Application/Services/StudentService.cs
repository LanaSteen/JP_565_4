using System;
using System.Collections.Generic;
using System.Text;
using University.Application.Exceptions;
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
				//Console.WriteLine("Student cannot be null.");
				throw new NotValidStudertnException();
			}
			if(student.Age < 0)
			{
				//Console.WriteLine("Student age cannot be negative.");
				throw new NotValidStudertnException("Student age cannot be negative.");
			}

			_studentRepository.SaveStudent(student);



		}
		public List<Student> GetAllStudents()
		{
			var studentList = _studentRepository.GetAllStudents();
			if(studentList == null || studentList.Count == 0)
			{
	
				throw new StudentNotFoundException();
			}
			return _studentRepository.GetAllStudents();
		}


		public Student GetStudentById(int id)
		{
			var student = _studentRepository.GetStudentById(id);
			if (student == null)
			{
				throw new StudentNotFoundException($"No student found with ID: {id}");
			
			}
			return student;
		}

		public void DeleteAllStudents()
		{
			_studentRepository.DeleteAllStudents();
		}
		public void DeleteStudentById(int id)
		{
			var student = _studentRepository.GetStudentById(id);
			if (student == null)
			{
				throw new StudentNotFoundException($"No student found with ID: {id}");
			}
			_studentRepository.DeleteStudentById(id);
		}



		public void UpdateStudent(Student updatedStudent)
		{
			var student = _studentRepository.GetStudentById(updatedStudent.Id);
			if (student == null)
			{
				throw new StudentNotFoundException($"No student found with ID: {updatedStudent.Id}");
			}
			_studentRepository.UpdateStudent(updatedStudent);
		}
	}
}
