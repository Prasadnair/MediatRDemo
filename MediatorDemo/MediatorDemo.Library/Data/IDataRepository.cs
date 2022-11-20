using MediatorDemo.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDemo.Library.Data
{
    public interface IDataRepository
    {
        List<StudentModel> GetStudents();
        StudentModel AddStudent(StudentModel student);

        StudentModel  GetStudentById(int id);
    }
}
