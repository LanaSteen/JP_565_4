using System;
using System.Collections.Generic;
using System.Text;
using University.Domain.Models;

namespace University.Domain.Interfaces
{
	public interface IStudetnRepository
	{
		void SaveStudent(Student student);
		List<Student> GetAllStudents();
	}
}
