﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HTTP5112_Cumulative_1.Models;
using MySql.Data.MySqlClient;

namespace HTTP5112_Cumulative_1.Controllers
{
    public class StudentDataController : Controller
    {
        private SchoolDbContext School = new SchoolDbContext();

        [HttpGet]
        [Route("api/StudentData/ListStudents")]
        public IEnumerable<Student> ListStudents()
        {
            MySqlConnection Conn = School.AccessDatabase();

            Conn.Open();

            MySqlCommand cmd = Conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM students";

            MySqlDataReader ResultSet = cmd.ExecuteReader();

            List<Student> Students = new List<Student> { };

            while (ResultSet.Read())
            {
                int StudentId = Convert.ToInt32(ResultSet["studentid"]);
                string StudentFname = ResultSet["studentfname"].ToString();
                string StudentLname = ResultSet["studentlname"].ToString();
                string StudentNumber = ResultSet["studentnumber"].ToString();
                string EnrolDate = ResultSet["enroldate"].ToString();

                Student MyStudent = new Student();
                MyStudent.StudentId = StudentId;
                MyStudent.StudentFname = StudentFname;
                MyStudent.StudentLname = StudentLname;
                MyStudent.StudentNumber = StudentNumber;
                MyStudent.EnrolDate = EnrolDate;

                Students.Add(MyStudent);
            }

            Conn.Close();

            return Students;
        }

        /// <summary>
        /// This controller will find a student in the system given an ID
        /// </summary>
        /// <param name="id">The student primary key</param>
        /// <returns>A student object</returns>
        /// <example>GET api/StudentData/FindStudent</example>
        [HttpGet]
        [Route("api/StudentData/FindStudent")]
        public Student FindStudent(int id)
        {
            MySqlConnection Conn = School.AccessDatabase();

            Conn.Open();

            MySqlCommand cmd = Conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM Students WHERE Studentid = " + id;

            MySqlDataReader ResultSet = cmd.ExecuteReader();

            Student NewStudent = new Student();

            while (ResultSet.Read())
            {
                int StudentId = Convert.ToInt32(ResultSet["studentid"]);
                string StudentFname = ResultSet["studentfname"].ToString();
                string StudentLname = ResultSet["studentlname"].ToString();
                string StudentNumber = ResultSet["studentnumber"].ToString();
                string EnrolDate = ResultSet["enroldate"].ToString();

                NewStudent.StudentId = StudentId;
                NewStudent.StudentFname = StudentFname;
                NewStudent.StudentLname = StudentLname;
                NewStudent.StudentNumber = StudentNumber;
                NewStudent.EnrolDate = EnrolDate;
            }

            Conn.Close();

            return NewStudent;
        }
    }
}

