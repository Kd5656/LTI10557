using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    internal class Student
    {
        public int rollno { get; set; } 
        public string name { get; set; }
        //-1,1 or 0
        //float avg=marks/5
        public int CompareTo(Object obj)
        {
            Student student = obj as Student;
            if (this.rollno < student.rollno)
                return -1;

            else if (this.rollno > student.rollno)
                return 1;

            else
                return 0;
        }



        public override string ToString()
        {
            return rollno+" "+name;
        }
    }

}
