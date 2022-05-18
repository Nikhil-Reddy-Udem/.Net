using edproject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace edproject.Controllers
{
    [Route("api/abc")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        StudentDBContext context;
        public StudentController(StudentDBContext con)
        {
            context = con;
        }
       [Route("add")]
       [HttpGet]
       public ActionResult addstudent(int id,string name)
        {
            Student stu = new Student();
            stu.Id = id;
            stu.Name = name;
            context.Students.Add(stu);
            context.SaveChanges();
            return Ok("Success");
        }
        [Route("show")]
       // [HttpGet]
        public ActionResult showdetails()
        {
            Student stu = new Student();
            var students = context.Students.ToList();
            return Ok(students);
        }
    }
}
