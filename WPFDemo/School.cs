//Anthony Franklin afranklin18@cnm.edu
//FranklinWPFDemo
//04/04/2022

/*
COMPLETELY REVISED TO INTEGRATED FEATURES FROM PREVIOUS VERSION WITH DATABASE AND OTHER NEW FEATURES 04/04/2022
 */

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace WPFDemo
{
    class School
    {
        private List<string> course;
        private List<string> major;
        private List<string> campus;
        private List<Student> student;


        public List<string> Course
        {
            get { return course; }
            set { course = value; }
        }

        public List<string> Major
        {
            get { return major; }
            set { major = value; }
        }

        public List<string> Campus
        {
            get { return campus; }
            set { campus = value; }
        }

        public List<Student> Students
        {
            get { return student; }
            set { student = value; }
        }

        public School()
        {
            course = GetData("SELECT * FROM Courses");
            major = GetData("SELECT * FROM Major");
            campus = GetData("SELECT * FROM Campuses");
            student = new List<Student>();
        }

        private List<string> GetData(string sqlStr)
        {
            var items = new List<string>();
            var connStr = ConfigurationManager.ConnectionStrings["SchoolDB"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand selectCmd = new SqlCommand(sqlStr, conn);
                conn.Open();
                SqlDataReader dr = selectCmd.ExecuteReader();
                while(dr.Read())
                {
                    items.Add(dr.GetString(1));
                }
            }
            return items;
        }
    }

}
