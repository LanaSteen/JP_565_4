using System;
using System.Collections.Generic;
using System.Text;
using University.Domain.Interfaces;
using University.Domain.Models;

namespace University.Infrastructure
{
	public class StudetnRepository : IStudetnRepository
	{
		private readonly string _path = @"C:\Users\l4nst\Desktop\JP_565_4 online\University.Infrastructure\Data\Student.txt";

		public void SaveStudent(Student student)
		{
			File.AppendAllLines(_path, new List<string> { student.ToString() });
		}

		public List<Student> GetAllStudents()
		{
			var studentLines = File.ReadAllLines(_path).ToList();
			List<Student> studentList = new List<Student>();
			foreach (var line in studentLines)
			{
				var parts = line.Split('|');
				Student student = new Student();
				// Assuming Student class has properties Id, Name, Age, and Grade
				student.Id = int.Parse(parts[0]);
				student.Name = parts[1];
				student.Age = int.Parse(parts[2]);
				student.Grade = parts[3];
				studentList.Add(student);
			}
			return studentList;
		}
	
	
	   public Student GetStudentById(int id)
		{
			var students = GetAllStudents();
			var singleStudent = students.FirstOrDefault(x => x.Id == id);
			return singleStudent;
		}
	
		public void DeleteAllStudents()
		{
			File.WriteAllText(_path, ""); // Clear the file content
		}

		public void DeleteStudentById(int id)
		{
			var students = GetAllStudents();
			var studentToDelete = students.FirstOrDefault(x => x.Id == id);
			if (studentToDelete != null)
			{
				students.Remove(studentToDelete);
				var linesToWrite = students.Select(s => s.ToString()).ToList();
				File.WriteAllLines(_path, linesToWrite);
			}
		}


		public void UpdateStudent(Student updatedStudent)
		{
			var students = GetAllStudents();
			var studentToUpdate = students.FirstOrDefault(x => x.Id == updatedStudent.Id);
			if (studentToUpdate != null)
			{
				studentToUpdate.Name = updatedStudent.Name;
				studentToUpdate.Age = updatedStudent.Age;
				studentToUpdate.Grade = updatedStudent.Grade;
				var linesToWrite = students.Select(s => s.ToString()).ToList();
				File.WriteAllLines(_path, linesToWrite);
			}
		}


	}
}
