using Lab_10.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab_10.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail()
        {
            StudentModel student = new StudentModel();
            student.Age = 21;
            student.FirstName = "Sushmita";
            student.LastName = "Shrestha";
            student.Grade = 'A';
            student.PhoneNumber = 9800000000;
            return View(student);
        }

        public IActionResult Details()
        {
            List<StudentModel> students = new List<StudentModel>
            {
                new StudentModel {Age = 21, FirstName = "Sushma", LastName = "Rai", Grade = 'A', PhoneNumber = 9711111111},
                new StudentModel {Age = 23,FirstName = "Ram", LastName = "Karki", Grade = 'C', PhoneNumber = 97222222222},
                new StudentModel {Age = 25, FirstName = "Shyam", LastName = "Khadka", Grade = 'F', PhoneNumber =  9733333333},
                new StudentModel {Age = 20, FirstName = "Sita", LastName = "Tamang", Grade = 'B', PhoneNumber = 9811111111 }
            };

            return View(students);
        }

        public IActionResult CreateStudent()
        {
            return View();
        }
    }
}
