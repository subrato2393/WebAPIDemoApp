using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApiCRUD.Contexts;
using WebApiCRUD.Models;

namespace WebApiCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private ApiDbContext _context;
        public StudentsController(ApiDbContext context)
        {
            _context = context;
        }
       
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            var student = new Student();
            var students = student.GetAllStudents(_context);
            return students;
        }

        [HttpGet("{id}")]
        public Student Get(int id)
        {
            var student = _context.Students.FirstOrDefault(x => x.Id == id);
            return student;
        }
        [HttpPost]
        public IActionResult Post(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return Ok(student);
        }
        [HttpPut("{id}")]
        public void Put(int id, Student student)
        {
            var existingStudent = _context.Students.FirstOrDefault(x => x.Id == id);
            existingStudent.Name = student.Name;
            existingStudent.Email = student.Email;
            existingStudent.PhoneNo = student.PhoneNo;
            _context.SaveChanges();
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var existingStudent = _context.Students.FirstOrDefault(x => x.Id == id);
            _context.Remove(existingStudent);
            _context.SaveChanges();
        }
    }
}
