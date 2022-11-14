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
    public class ClassDataController : Controller
    {
        private SchoolDbContext School = new SchoolDbContext();

        /// <summary>
        /// This controller will access the classes table of school database and return a list of classes in the school database.
        /// </summary>
        /// <returns>A list of classes (class codes)</returns>
        /// <example>GET api/ClassData/ListClasses</example>
        [HttpGet]
        [Route("api/ClassData/ListClasses")]
        public IEnumerable<Class> ListClasses(string SearchKey = null)
        {
            MySqlConnection Conn = School.AccessDatabase();

            Conn.Open();

            MySqlCommand cmd = Conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM classes where lower(classcode) like lower(@key) or lower(classname) like lower(@key) or lower(concat(classcode, ' ', classname)) like lower(@key)";

            cmd.Parameters.AddWithValue("@key", "%" + SearchKey + "%");
            cmd.Prepare();

            MySqlDataReader ResultSet = cmd.ExecuteReader();

            List<Class> Classes = new List<Class> { };

            while (ResultSet.Read())
            {
                int ClassId = Convert.ToInt32(ResultSet["classid"]);
                string ClassCode = ResultSet["classcode"].ToString();
                int TeacherId = Convert.ToInt32(ResultSet["teacherid"]);
                string StartDate = ResultSet["startdate"].ToString();
                string FinishDate = ResultSet["finishdate"].ToString();
                string ClassName = ResultSet["classname"].ToString();

                Class MyClass = new Class();
                MyClass.ClassId = ClassId;
                MyClass.ClassCode = ClassCode;
                MyClass.TeacherId = TeacherId;
                MyClass.StartDate = StartDate;
                MyClass.FinishDate = FinishDate;
                MyClass.ClassName = ClassName;

                Classes.Add(MyClass);
            }

            Conn.Close();

            return Classes;
        }

        /// <summary>
        /// This controller will find a class in the system given an ID
        /// </summary>
        /// <param name="id">The class primary key</param>
        /// <returns>A class object</returns>
        /// <example>GET api/ClassData/FindClass</example>
        [HttpGet]
        [Route("api/ClassData/FindClass")]
        public Class FindClass(int id)
        {
            MySqlConnection Conn = School.AccessDatabase();

            Conn.Open();

            MySqlCommand cmd = Conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM classes WHERE classid = @id";

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();

            MySqlDataReader ResultSet = cmd.ExecuteReader();

            Class NewClass = new Class();

            while (ResultSet.Read())
            {
                int ClassId = Convert.ToInt32(ResultSet["classid"]);
                string ClassCode = ResultSet["classcode"].ToString();
                int TeacherId = Convert.ToInt32(ResultSet["teacherid"]);
                string StartDate = ResultSet["startdate"].ToString();
                string FinishDate = ResultSet["finishdate"].ToString();
                string ClassName = ResultSet["classname"].ToString();

                NewClass.ClassId = ClassId;
                NewClass.ClassCode = ClassCode;
                NewClass.TeacherId = TeacherId;
                NewClass.StartDate = StartDate;
                NewClass.FinishDate = FinishDate;
                NewClass.ClassName = ClassName;
            }

            Conn.Close();

            return NewClass;
        }
    }
}

