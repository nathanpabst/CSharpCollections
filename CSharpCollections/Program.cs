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
            students.RemoveAt(2);
            foreach (string student in students)
            {
                Console.WriteLine(student);
            }
            Console.Read();
        }
    }
}
