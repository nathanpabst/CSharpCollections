using System;
using System.Collections.Generic;

namespace CSharpCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------LISTS-------------------
            //add using System.Collections.Generic to the top
            //instantiating a list using a collection initializer      
            List<string> students = new List<string>(5) { "Sue", "Bill", "Allen", "Bob", "Mary"};
            List<string> students2 = new List<string>(students);
            string[] studentArray = students.ToArray();
            //adding a new student at index 1
            students.Insert(1, "Frank");
            //removing a student
            students.RemoveAt(2);
            //when you don't know the index value..Remove() will find/remove the first instance of the parameter
            //behind the scenes Remove is using the IndexOf() and RemoveAt() methods
            students.Remove("Bob");
            foreach (string student in students)
            {
                Console.WriteLine(student);
            }
            Console.Read();
        }
    }
}
