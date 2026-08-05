using Lab10.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab10.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            
            List<StudentModel> students = new List<StudentModel>
            {
                new StudentModel { id = 101, name = "John Doe", grade = 'A' },
                new StudentModel { id = 102, name = "Jane Smith", grade = 'B' },
                new StudentModel { id = 103, name = "Alice Johnson", grade = 'C' }
            };
            return View(students);
        }
    }
}
