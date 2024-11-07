using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{
    internal class Student
    {
        private int studentID, age;
        private string fullName, course;

        public Student(int studentID, string fullName, int age, string course)
        {
            StudentID = studentID;
            Age = age;
            FullName = fullName;
            Course = course;
        }

        public int StudentID { get => studentID; set => studentID = value; }

        public string FullName { get => fullName; set => fullName = value; }
        
        public int Age { get => age; set => age = value; }

        public string Course { get => course; set => course = value; }
    }
}
