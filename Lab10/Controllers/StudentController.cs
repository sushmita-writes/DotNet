using Lab10.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data.SqlTypes;

namespace Lab10.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail()
        {
            StudentModel student = new StudentModel() { id = 100, name = "Sushmita Shrestha", grade = 'A' };
            return View(student);
        }

        public IActionResult Details()
        {
            
            List<StudentModel> students = new List<StudentModel>
            {
                new StudentModel { id = 101, name = "John Doe", grade = 'A' },
                new StudentModel { id = 102, name = "Jane Smith", grade = 'B' },
                new StudentModel { id = 103, name = "Alice Johnson", grade = 'C' }
            };
            return View(students);
        }

        public IActionResult CreateStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateStudent(StudentModel student)
        {
            // step1 : connect to database
            string connect = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Student;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30";
            SqlConnection conn = new SqlConnection(connect);

            // step2 : command
            string query = "INSERT INTO Student (id, name, grade) VALUES (100, 'Sushmita Shrestha', 'A')";
            SqlCommand cmd = new SqlCommand(query, conn);

            // step3: execute command
            conn.Open();
            cmd.ExecuteNonQuery();

            // step4: process result (for select)
            conn.Close();

            return View();
        }
    }
}
