using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCollections
{
    class SchoolRoll
    {
        //ISet interface does not allow duplicate items
        private HashSet<Student> _students = new HashSet<Student>();
        
        public IEnumerable<Student> Students { get { return _students; } }

        public void AddStudents(IEnumerable<Student> students)
        {
            _students.UnionWith(students);
        }
    }
}
