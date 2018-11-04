using System;
using System.Collections.Generic;

namespace CSharpCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------SORT-------------------
            List<Student> students = new List<Student>
            {
                new Student() { Name = "Sally", GradeLevel = 3},
                new Student() { Name = "Bob", GradeLevel = 3},
                new Student() { Name = "Sally", GradeLevel = 2}
            };

            //create an instance of SchoolRoll & add students using the AddStudents method
            SchoolRoll schoolRoll = new SchoolRoll();
            schoolRoll.AddStudents(students);

            foreach (Student student in schoolRoll.Students)
            {
                Console.WriteLine($"{student.Name} is in grade {student.GradeLevel}");
            }
            Console.Read();
        }
    }
}
