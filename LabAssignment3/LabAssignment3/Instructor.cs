using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment3
{
    class Instructor
    {
        public string Name;
        public string CourseName;

        public Instructor(string name, string course)
        {
            this.Name = name;
            this.CourseName = course;
        }
        public void SetStudentGrade(Student student, int grade)
        {
            student.SetGrade(grade);
        }

        public void PrintInstructorInfo()
        {
            System.Console.WriteLine("Instructor", this.Name);
            System.Console.WriteLine("Course", this.CourseName);

        }
         
    }
}
