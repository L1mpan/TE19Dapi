using System.Collections.Generic;
using TE19Dapi.models;

namespace TE19Dapi.Services.StudentServices
{
    public interface IStudentService
    {
         List<Student> GetStudentList();

         List<Student> AddStudent(Student newStudent);

         List<Student> DeleteStudent(int Id);

         List<Student> UpdateStudent(Student updateStudent);
    }
}