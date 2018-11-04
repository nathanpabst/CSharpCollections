using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCollections
{
    class SchoolRoll
    {
        private List<Student> _students = new List<Student>();

        //IEnumerable<T> exposes the enumerator..supports a simple iteration (like foreach loops) over a collection of a specified type
        public void AddStudents(IEnumerable<Student> students)
        {
            _students.AddRange(students);
        }
    }
}
