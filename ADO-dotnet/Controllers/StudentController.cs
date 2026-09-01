using ADO_dotnet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace ADO_dotnet.Controllers
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
            student.Id = 100;
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
                new StudentModel {Id = 101, Age = 21, FirstName = "Sushma", LastName = "Rai", Grade = 'A', PhoneNumber = "+977 9711111111"},
                new StudentModel {Id = 102, Age = 23, FirstName = "Ram", LastName = "Karki", Grade = 'C', PhoneNumber = "+977 97222222222"},
                new StudentModel {Id = 103, Age = 25, FirstName = "Shyam", LastName = "Khadka", Grade = 'F', PhoneNumber =  "+977 9733333333"},
                new StudentModel {Id = 104, Age = 20, FirstName = "Sita", LastName = "Tamang", Grade = 'B', PhoneNumber = "+977 9811111111" }
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

            string conn_string = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Sushmita;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30";
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

        public IActionResult ViewData()  // Template: Index
        {
            string conn_string = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Sushmita;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30";
            SqlConnection conn = new SqlConnection(conn_string);
            conn.Open();

            string query = string.Format("SELECT * FROM Student");
            SqlCommand cmd = new SqlCommand(query, conn);

            List<StudentModel> students = new List<StudentModel>();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                StudentModel s = new StudentModel();
                s.Id = Convert.ToInt32(reader["Id"]);
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

        public IActionResult IdDetails(int id)
        {
            string conn_string = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Sushmita;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30";
            SqlConnection conn = new SqlConnection(conn_string);
            conn.Open();

            string query = string.Format("SELECT * FROM Student WHERE Id = {0}", id);
            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataReader reader = cmd.ExecuteReader();
            StudentModel student = null;
            if (reader.Read())
            {
                student = new StudentModel();
                student.Id = Convert.ToInt32(reader["Id"]);
                student.FirstName = Convert.ToString(reader["FirstName"]);
                student.LastName = Convert.ToString(reader["LastName"]);
                student.Age = Convert.ToInt32(reader["Age"]);
                student.Grade = Convert.ToChar(reader["Grade"]);
                student.PhoneNumber = Convert.ToString(reader["PhoneNumber"]);
            }

            conn.Close();
            return View(student);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            StudentModel student = null;

            string conn_string = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Sushmita;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30";
            SqlConnection conn = new SqlConnection(conn_string);
            SqlCommand cmd = new SqlCommand("SELECT Id, FirstName, LastName, Age, Grade, PhoneNumber FROM Student WHERE Id = @Id", conn);
            cmd.Parameters.AddWithValue("@Id", id);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                student = new StudentModel
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    Age = Convert.ToInt32(reader["Age"]),
                    Grade = Convert.ToChar(reader["Grade"]),
                    PhoneNumber = reader["PhoneNumber"].ToString()
                };
            }

            conn.Close();
            return View(student);
        }

        // POST: Student/Delete/5
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {

            string conn_string = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Sushmita;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30";
            SqlConnection con = new SqlConnection(conn_string);
            SqlCommand cmd = new SqlCommand("DELETE FROM Student WHERE Id = @Id", con);
            cmd.Parameters.AddWithValue("@Id", id);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(int id, StudentModel student)
        {
            string conn_string = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Sushmita;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30";
            SqlConnection conn = new SqlConnection(conn_string);
            conn.Open();

            string query = String.Format(
                "UPDATE Student SET FirstName = '{0}', LastName = '{1}', Age = {2}, Grade = '{3}', PhoneNumber = '{4}' WHERE Id = {5}",
                student.FirstName, student.LastName, student.Age, student.Grade, student.PhoneNumber, id
            );

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
            return View();
        }
    }
}
