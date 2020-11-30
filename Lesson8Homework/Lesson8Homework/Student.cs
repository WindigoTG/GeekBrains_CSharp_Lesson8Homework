using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8Homework
{
    [Serializable]
    public class Student
    {
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string university { get; set; }
        public string faculty { get; set; }
        public int course { get; set; }
        public string city { get; set; }
        public int age { get; set; }

        public Student(string firstName, string lastName, string university, string faculty, int age, int course, string city)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.university = university;
            this.faculty = faculty;
            this.course = course;
            this.age = age;
            this.city = city;
        }
        public Student()
        { 
        }
    }
}
