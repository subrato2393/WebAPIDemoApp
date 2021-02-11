using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiCRUD.Contexts;

namespace WebApiCRUD.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; } 
        public string  PhoneNo { get; set; }

       
        public IList<Student> GetAllStudents(ApiDbContext context)
        {
            var students= context.Students.ToList();
            return students;
        }
        public void AddStudent(ApiDbContext context)
        {
            //context.Students.Add()
        }
    }
}
