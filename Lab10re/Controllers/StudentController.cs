using Lab10re.Models;
using Microsoft.AspNetCore.Mvc;
using Lab10re.Models;
using Microsoft.Data.SqlClient;

namespace Lab10re.Controllers
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
            student.PhoneNumber = "+977 9800000000";
            return View(student);
        }

        public IActionResult Details()
        {
            List<StudentModel> students = new List<StudentModel>
        {
            new StudentModel {Age = 21, FirstName = "Sushma", LastName = "Rai", Grade = 'A', PhoneNumber = "+977 9711111111"},
            new StudentModel {Age = 23,FirstName = "Ram", LastName = "Karki", Grade = 'C', PhoneNumber = "+977 97222222222"},
            new StudentModel {Age = 25, FirstName = "Shyam", LastName = "Khadka", Grade = 'F', PhoneNumber =  "+977 9733333333"},
            new StudentModel {Age = 20, FirstName = "Sita", LastName = "Tamang", Grade = 'B', PhoneNumber = "+977 9811111111" }
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
            string conn_string = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Student;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30";
            SqlConnection conn = new SqlConnection(conn_string);

            string query = "INSERT INTO [dbo].[Student](Age, FirstName, LastName, Grade, PhoneNumber) VALUES (21, 'Sushmita', 'Shrestha', 'A', '+977 9800000000')";
            SqlCommand cmd = new SqlCommand(query, conn);

            conn.Open();
            cmd.ExecuteNonQuery();

            conn.Close();


            return View();
        }

    }

}
