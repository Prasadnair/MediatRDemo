using MediatorDemo.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDemo.Library.Data
{
    public class DataRepository : IDataRepository
    {
        private static List<StudentModel> _students = new()
        {
            new StudentModel { Id=3456, Name="Prasad Raveendran", School="Mount Fort"},
            new StudentModel { Id=6543, Name="Prabha Raveendran", School="St. Pious"}
        };
        public StudentModel AddStudent(StudentModel student)
        {
            _students.Add(student);
            return student;
        }

        public StudentModel GetStudentById(int id)
        {
            return _students.Where(s => s.Id == id).FirstOrDefault(new StudentModel());
        }

        public List<StudentModel> GetStudents()
        {
            return _students;
        }
    }
}
