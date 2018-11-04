using System;
using System.Collections.Generic;
using System.Text;


namespace CSharpCollections
{
    //IComparable generic interface requires the CompareTo method
    class Student : IComparable<Student>
    {
        public string Name { get; set; }
        public int GradeLevel { get; set; }

        //
        public int CompareTo(Student that)
        {
            int result = this.Name.CompareTo(that.Name);

            if (result == 0)
            {
                result = this.GradeLevel.CompareTo(that.GradeLevel);
            }
            return result;
        }
    }
}
