using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TE19Dapi.models;
using TE19Dapi.Services.StudentServices;

namespace TE19Dapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        
        [HttpGet]
        public ActionResult<List<Student>> GetStudent() 
        {
            return Ok(_studentService.GetStudentList());
        }

        [HttpPost]
        public ActionResult<List<Student>> AddStudent(Student newStudent) 
        {
            return Ok(_studentService.AddStudent(newStudent));
        }

        [HttpDelete]
        public ActionResult<List<Student>> DeleteStudent(int id) 
        {
            return Ok(_studentService.DeleteStudent(id));
        }

        [HttpPut]
        public ActionResult<List<Student>> UpdateStudent(Student updateStudent)
        {
            return Ok(_studentService.UpdateStudent(updateStudent));
        }
    }
}