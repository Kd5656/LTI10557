using System;
using System.Collections.Generic;
using System.Text;

namespace SaturdayAssign3
{
    internal class Student
    {
        int Id;
        string Name;
        string  Address;
        public Student(int id,string name,string address)
        {
            Id = id; 
            Name = name;
            Address = address;

        }
        public void Display()
        {
            Console.WriteLine("Student ID="+Id+"\n Student Name ="+Name+"\n Student Address="+Address); 
        }


    }
}
