using System.Collections.Generic;
using System.Linq;
using TE19Dapi.models;

namespace TE19Dapi.Services.StudentServices
{
    public class StudentService : IStudentService
    {
        private static List<Student> studentLista = new List<Student>() 
        {
            new Student() { Id = 1, Name = "Linus", classStudent = StudentClass.TE19D },
            new Student() { Id = 2, Name = "Albert", classStudent = StudentClass.TE19D },
            new Student() { Id = 3, Name = "Jonas", classStudent = StudentClass.TE19D },
        };
        private readonly DataContext _context;

        public StudentService(DataContext context)
        {
            _context = context;
        }

        public List<Student> AddStudent(Student newStudent)
        {
            _context.students.Add(newStudent);
            _context.SaveChanges();
            return _context.students.ToList();
        }

        public List<Student> GetStudentList()
        {
            return _context.students.ToList();
        }

        public List<Student> DeleteStudent(int id)
        {
            var hittadStudent = _context.students.FirstOrDefault(student => student.Id == id);

            _context.students.Remove(hittadStudent);
            _context.SaveChanges();

            return _context.students.ToList();
        }

        public List<Student> UpdateStudent(Student updateStudent)
        {
            var hittadStudent = _context.students.FirstOrDefault(student => student.Id == updateStudent.Id);

            if(hittadStudent != null) 
            {
                hittadStudent.Name = updateStudent.Name;
                hittadStudent.Age = updateStudent.Age;
            }

            _context.SaveChanges();
            return _context.students.ToList();
        }
    }
}