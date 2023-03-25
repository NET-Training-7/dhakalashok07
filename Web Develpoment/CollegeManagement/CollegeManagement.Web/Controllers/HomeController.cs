//using CollegeManagement.Web.Models;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Data.SqlClient;
//using System.Diagnostics;

//namespace CollegeManagement.Web.Controllers
//{
//    public class HomeController : Controller
//    {
//        public IActionResult Index() 
//        {
//        return View();
//        }

//        public IActionResult LearnAdoNET()
//        {
//            //Fetch student data from student table 
//            string connectionString = " string connectionString = \"Data Source=(localdb)\\\\MSSQLLocalDB;Initial Catalog=CollegeDb_test;Integrated Security=True;"
//                        SqlConnection connection = new SqlConnection(connectionString);
//            SqlCommand command = new SqlCommand("Select * from dbo.Student", connection);

//            connection.Open();
//            SqlDataReader reader = command.ExecuteReader();

//            List<Student> students = new List<Student>();
//            while (reader.Read())
//            {
//                var student = new Student()
//                {
//                    RollNo = reader.GetInt32(0),
//                    Name = reader.GetString(1),
//                    Contact = reader.GetString(2),
//                    Major = reader.GetString(3),
//                    Semester = reader.GetString(5),
//                };
//                students.Add(student);
//            }
//              return View("ADO",students);
//        }
//    }
//    public IActionResult Privacy()
//    {
//        return view();
//    }
//}
using CollegeManagement.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Diagnostics;

namespace CollegeManagement.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LearnAdoNET()
        {
            //Fetch student data from student table 
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CollegeDb_test;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Select * from dbo.Student", connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<Student> students = new List<Student>();
            while (reader.Read())
            {
                var student = new Student()
                {
                    RollNo = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Contact = reader.GetString(2),
                    Major = reader.GetString(3),
                    Semester = reader.GetString(5),
                };
                students.Add(student);
            }
            return View("ADO", students);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}




