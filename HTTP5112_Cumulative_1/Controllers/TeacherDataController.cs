using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HTTP5112_Cumulative_1.Models;
using MySql.Data.MySqlClient;

namespace HTTP5112_Cumulative_1.Controllers
{
    public class TeacherDataController : Controller
    {
        private SchoolDbContext School = new SchoolDbContext();

        [HttpGet]
        [Route("api/TeacherData/ListTeachers")]
        public IEnumerable<Teacher> ListTeachers()
        {
            MySqlConnection Conn = School.AccessDatabase();

            Conn.Open();

            MySqlCommand cmd = Conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM teachers";

            MySqlDataReader ResultSet = cmd.ExecuteReader();

            List<Teacher> Teachers = new List<Teacher> { };

            while (ResultSet.Read())
            {
                int TeacherId = Convert.ToInt32(ResultSet["teacherid"]);
                string TeacherFname = ResultSet["teacherfname"].ToString();
                string TeacherLname = ResultSet["teacherlname"].ToString();
                string EmployeeNumber = ResultSet["employeenumber"].ToString();
                string HireDate = ResultSet["hiredate"].ToString();
                decimal Salary = Convert.ToDecimal(ResultSet["salary"]);

                Teacher MyTeacher = new Teacher();
                MyTeacher.TeacherId = TeacherId;
                MyTeacher.TeacherFname = TeacherFname;
                MyTeacher.TeacherLname = TeacherLname;
                MyTeacher.EmployeeNumber = EmployeeNumber;
                MyTeacher.HireDate = HireDate;
                MyTeacher.Salary = Salary;

                Teachers.Add(MyTeacher);
            }

            Conn.Close();

            return Teachers;
        }

        [HttpGet]
        [Route("api/TeacherData/FindTeacher")]
        public Teacher FindTeacher(int id)
        {
            Teacher NewTeacher = new Teacher();

            MySqlConnection Conn = School.AccessDatabase();

            Conn.Open();

            MySqlCommand cmd = Conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM teachers WHERE teacherid = " + id;

            MySqlDataReader ResultSet = cmd.ExecuteReader();

            while (ResultSet.Read())
            {
                int TeacherId = Convert.ToInt32(ResultSet["teacherid"]);
                string TeacherFname = ResultSet["teacherfname"].ToString();
                string TeacherLname = ResultSet["teacherlname"].ToString();
                string EmployeeNumber = ResultSet["employeenumber"].ToString();
                string HireDate = ResultSet["hiredate"].ToString();
                decimal Salary = Convert.ToDecimal(ResultSet["salary"]);

                NewTeacher.TeacherId = TeacherId;
                NewTeacher.TeacherFname = TeacherFname;
                NewTeacher.TeacherLname = TeacherLname;
                NewTeacher.EmployeeNumber = EmployeeNumber;
                NewTeacher.HireDate = HireDate;
                NewTeacher.Salary = Salary;
            }

            Conn.Close();

            return NewTeacher;
        }
    }
}

