using Lab10re.Models;
using Microsoft.AspNetCore.Mvc;
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

        public IActionResult CreateStudent()  // Template: Create
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateStudent(StudentModel student)
        {
            /*
            connectionString: "Data Source=DBServer;Database='Student';User Id=your_username;Password=your_password;";
            */

            string conn_string = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Student;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30";
            SqlConnection conn = new SqlConnection(conn_string);
            conn.Open();

            // ---------- Inserting static value ---------------
            //string query = "INSERT INTO Student(Age, FirstName, LastName, Grade, PhoneNumber) VALUES (21, 'Sushmita', 'Shrestha', 'A', '+977 9800000000')";
            //SqlCommand cmd = new SqlCommand(query, conn);
            //cmd.ExecuteNonQuery();

            // ---------- Inserting dynamic value -------------
            //string.Format()->Placeholder method
            string query = string.Format("INSERT INTO Student(Age, FirstName, LastName, Grade, PhoneNumber) "
                                + "VALUES ({0}, '{1}', '{2}', '{3}', '{4}')",
                                student.Age,
                                student.FirstName,
                                student.LastName,
                                student.Grade,
                                student.PhoneNumber
                            );
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
            return View();
        }

        [Route("list-of-students-in-the-database")]
        public IActionResult ViewData()  // Template: Index
        {
            string conn_string = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Student;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30";
            SqlConnection conn = new SqlConnection(conn_string);
            conn.Open();

            string query = string.Format("SELECT * FROM Student");
            SqlCommand cmd = new SqlCommand(query, conn);

            List<StudentModel> students = new List<StudentModel>();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                StudentModel s = new StudentModel();
                s.FirstName = Convert.ToString(reader["FirstName"]);
                s.LastName = Convert.ToString(reader["LastName"]);
                s.Age = Convert.ToInt32(reader["Age"]);
                s.Grade = Convert.ToChar(reader["Grade"]);
                s.PhoneNumber = Convert.ToString(reader["PhoneNumber"]);

                students.Add(s);
            }

            conn.Close();
            return View(students);
        }

        public IActionResult ViewDataCRUD()  // Template: CRUD
        {
            string conn_string = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Student;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30";
            SqlConnection conn = new SqlConnection(conn_string);
            conn.Open();

            string query = string.Format("SELECT * FROM Student");
            SqlCommand cmd = new SqlCommand(query, conn);

            List<StudentModel> students = new List<StudentModel>();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                StudentModel s = new StudentModel();
                s.FirstName = Convert.ToString(reader["FirstName"]);
                s.LastName = Convert.ToString(reader["LastName"]);
                s.Age = Convert.ToInt32(reader["Age"]);
                s.Grade = Convert.ToChar(reader["Grade"]);
                s.PhoneNumber = Convert.ToString(reader["PhoneNumber"]);

                students.Add(s);
            }

            conn.Close();
            return View(students);
        }

    }

}
