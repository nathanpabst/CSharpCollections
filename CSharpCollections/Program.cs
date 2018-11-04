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
            students.Sort();
            //adding a new student while maintaining the Sort()
            Student newStudent = new Student() { Name = "Joe", GradeLevel = 2 };
            //find out if Joe (the new student) is in the list using BinarySearch
            int index = students.BinarySearch(newStudent);
            //if Joe is in the list the index will have a positive integer. Otherwise we will add him using Insert().
            //~index is a bitwise operator. it negates the index and subtracts 1
            if (index < 0)
            {
                students.Insert(~index, newStudent);
            }
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.Name} is in grade {student.GradeLevel}");
            }
            Console.Read();
        }
    }
}
