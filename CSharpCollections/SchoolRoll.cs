using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCollections
{
    class SchoolRoll
    {
        private List<Student> _students = new List<Student>();
        //a 'client' is used to describe a class that uses another class in some way. ie accessing items inside of a collection stored within the class
        //add Students property exposing the Student list
        //changing the property type from List to IEnumerable reduces access of the client down to looping through the list
        //IEnumerable does not expose methods that will alter the list..readonly from the perspective of the client class
        public IEnumerable<Student> Students { get { return _students; } }

        //IEnumerable<T> exposes the enumerator..supports a simple iteration (like foreach loops) over a collection of a specified type
        public void AddStudents(IEnumerable<Student> students)
        {
            _students.AddRange(students);
        }
    }
}
