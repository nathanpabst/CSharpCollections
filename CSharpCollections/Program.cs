using System;
using System.Collections.Generic;

namespace CSharpCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------HASHSET-------------------
            HashSet<Student> students = new HashSet<Student>
            {
                new Student() { Name = "Sally", GradeLevel = 3},
                new Student() { Name = "Bob", GradeLevel = 3},
                new Student() { Name = "Sally", GradeLevel = 2}
            };

            // create/add new student to the list
            Student joe = new Student() { Name = "Joe", GradeLevel = 2 };
            students.Add(joe);

            Student duplicateJoe = new Student() { Name = "Joe", GradeLevel = 2 };
            students.Add(duplicateJoe);

            //following lines demonstrates that new objects will be duplicated in the list
            //hash sets use hash codes to determine if two objects are the same
            //GetHashCode returns an integer for every object
            //after overriding the Equals method the following hashcodes are identical
            //Console.WriteLine(joe.GetHashCode());
            //Console.WriteLine(duplicateJoe.GetHashCode());
            
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.Name} is in grade {student.GradeLevel}");
            }
            Console.Read();
        }
    }
}
