using System;



namespace CSharpCollections
{
    //IComparable interface to allow for sorting within the list. type parameter<Student>
    class Student : IComparable<Student>
    {
        //properties
        public string Name { get; set; }
        public int GradeLevel { get; set; }

        //method
        public int CompareTo(Student that)
        {
            int result = this.Name.CompareTo(that.Name);

            if (result == 0)
            {
                result = this.GradeLevel.CompareTo(that.GradeLevel);
            }
            return result;
        }

        //method overriding the GetHashCode method when the properties of the student object are the same
        public override int GetHashCode()
        {
            //GetHashCode will return a number unique to the object. ie the values of the name & gradelevel properties
            //combine the hash codes & return the value
            return Name.GetHashCode() + GradeLevel.GetHashCode();
        }
    }
}
