using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToProgramming_ExtraLabs03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            Student student2 = new Student();
            Student student3 = new Student();
            Student student4 = new Student();
            Student student5 = new Student();

            Student[] students = new Student[] { student1, student2, student3 };
            
            Course course = new Course();
            course.CourseName = "Programming with C#";

            course.Students = students;

            Teacher teacher = new Teacher();
            Teacher[] teachers = new Teacher[] { teacher };
            course.Teachers = teachers;

            Degree degree = new Degree();
            degree.DegreeLevel = "Bachelor";
            degree.Course = course;

            UProgram uProgram = new UProgram();
            uProgram.Name = "Information Technology";
            uProgram.Degree = degree;

            Console.WriteLine($"Program: { uProgram.Name }");
            Console.WriteLine($"Course: { uProgram.Degree.Course.CourseName }");
            Console.WriteLine($"Number of students in this course: { uProgram.Degree.Course.Students.Length }");
            Console.WriteLine($"Total students in the University: { Student.Counter }");

            Console.ReadKey();
        }
    }
}
