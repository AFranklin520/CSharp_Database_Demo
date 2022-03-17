using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDemo
{
    class School
    {
        private string[] courses;
        private string[] majors;
        private string[] campuses;
        private List<Student> students;

        public School()
        {
            courses = new string[] { "CIS 101", "CIS 102", "CIS 103", "CIS 104" };
            majors = new string[] { "Programming", "Web Design", "IT" };
            campuses = new string[] { "Main", "Montoya", "Rio Rancho" };
            students = new List<Student>();


        }

        public string[] Courses { get => courses; set => courses = value; }
        public string[] Majors { get => majors; set => majors = value; }
        public string[] Campuses { get => campuses; set => campuses = value; }
        public List<Student> Students { get => students; set => students = value; }
    }
}








