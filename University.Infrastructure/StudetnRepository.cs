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
	}
}
