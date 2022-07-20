using Microsoft.AspNetCore.Mvc;
using MVCFirstApp.Models;

namespace MVCFirstApp.Controllers
{
    [Route("[Controller]")]
    public class StudentController : Controller
    {
        [Route("Home")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("GetStudents")]
        public IActionResult getstudents()
        {
            List<StudentsModel> student = getstudent();
            return View(student);
        }
        [Route("ShowStudents")]
        public IActionResult showstudents(StudentsModel model)
        {
            List<StudentsModel> student= new List<StudentsModel>();
            student.Add(model);
            return View(student);
        }

        public List<StudentsModel> getstudent()
        {
            List<StudentsModel> students = new List<StudentsModel>();
            var s1 = new StudentsModel();
            s1.name = "Praveen";
            s1.regno = 1234;
            s1.branch = "CSE";
            students.Add(s1);

            var s2 = new StudentsModel();
            s2.name = "Praveen Kumar";
            s2.regno = 12345;
            s2.branch = "CSE";
            students.Add(s2);

            var s3 = new StudentsModel();
            s3.name = "Praveen Reddy";
            s3.regno = 123456;
            s3.branch = "CSE";
            students.Add(s3);

            return students;
        }



    }
}
