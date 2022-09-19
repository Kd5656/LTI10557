using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Linq;

namespace ConsoleApp14
{
    internal class Student
    {
        public int Id { get; set; }  

        public string Name { get; set; }    
       
        public string Gender { get; set; }  
        public string Branch { get; set; }

        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>()
            {
            new Student(){Id= 1, Name = "HArshad",Gender="MAle",Branch="Softare Development"},
            new Student() { Id = 2, Name = "Karishma", Gender = "female", Branch = "Computer Science" },
            new Student() { Id = 3, Name = "HArshada", Gender = "female", Branch = "Softare Development" },
            new Student() { Id = 4, Name = "Mayur", Gender = "Male", Branch = "BCA" },
            new Student() { Id = 5, Name = "lata", Gender = "female", Branch = "Softare Development" },
             };
            return students;

        }

    }
}
