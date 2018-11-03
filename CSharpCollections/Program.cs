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
            //creating a list with a <string> object called students and instantiating the list
            //'students' is essentially an array encapsulated in a list object, so the array can change as much as needed without having to update all classes referencing it.
            List<string> students = new List<string>();
            students.Add("Sue");
            students.Add("Bill");
            students.Add("Allen");
            Console.WriteLine(students.Count);
            Console.WriteLine(students[1]);
            //getting the last item in the list
            Console.WriteLine(students[students.Count - 1]);
            //Capacity will create a new array 2x the size of the original
            Console.WriteLine(students.Capacity);
            //ex. instantiating a new list with a capacity of 500
            List<string> teachers = new List<string>(500);

            //---------ADDING TO ARRAYS--------------
            //starting array containing three values
            //int[] ages = { 24, 31, 56 };
            ////adding a new array that holds four values
            //int[] agesCopy = new int[4];
            ////using CopyTo method to ages into the larger array
            //ages.CopyTo(agesCopy, 1);
            ////inserting the value 16 to the first position in the agesCopy array
            //agesCopy[0] = 16;
            ////overriding the copied value back into the ages variable
            //ages = agesCopy;
            ////use debugger to see results
            ////note..other classes uses a reference to the ages array will not reflect these changes. 
            ////every class using the ages variable would need to be changed
            ////this is an inefficient practice and could slow the program down. 
            ////same applies to removing an item from an array. use List instead (see example above).

            Console.Read();
        }
    }
}
