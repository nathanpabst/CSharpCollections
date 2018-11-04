using System;



namespace CSharpCollections
{
    //IComparable interface to allow for sorting within the list. type parameter<Student>
    class Student : IComparable<Student>
    {
        //properties
        public string Name { get; set; }
        public int GradeLevel { get; set; }

        //implement the IComparable generic interface with the CompareTo method below
        //compares the current instance with another object of the same type and returns an integer
        //that indicates whether the current instance precedes, follows, or occurs in the same position
        //in the sort order as the other object.
        //CompareTo returns an integer. negative number if the object should be ordered before the object passed in
        //positive number if the object should be ordered after && zero if objects are equivilent
        //here we are sorting first by Name and then by grade level 
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
