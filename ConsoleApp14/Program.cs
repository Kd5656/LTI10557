using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* List<Student> mystudents = new List<Student>();
             {
                 new Student() { Id = 8, Name = "Lithika", Gender = "Female", Branch = "BCA" };
                 new Student() { Id = 9, Name = "Nikita", Gender = "Female", Branch = "BCA" };

             };
             var result = from stud in mystudents
                          where stud.Branch == "BCA" 
                           select stud;

              foreach (Student s in result)
                  Console.WriteLine(s.Name + "   " + s.Id);
              var result = from s in mystudents
                           where s.Gender == "Female"
                           select s;
                foreach(Student student in result)
              {
                  Console.WriteLine(student.Id);
              }*/

            //LAMBDA EXPRESSION IS FOR THE DEVELOPER COMING FROM C# LANGUAGE BACKGROUND
            //to Get complete list of students
            //var result = Student.GetStudents().ToList();
            //foreach(Student stud in result)
            //{
            //  Console.WriteLine(stud.Name+" "+stud.Branch);
            //}
            //where clause can be replaced by Lambda expression  as Follows

            //var R1 = Student.GetStudents().Where(s => s.Id < 5);

            //foreach (Student k in R1)
            //{
            //    Console.WriteLine(k.Name + " " + k.Branch);
            //}

            //var R2 = Student.GetStudents().Single(s => s.Name == "lata");
            //Console.WriteLine(R2.Name + " " + R2.Branch);

            //var R3 = Student.GetStudents().SingleOrDefault(s => s.Name == "lata");
            //Console.WriteLine(R3.Name + " " + R3.Branch);


            //var R4 = Student.GetStudents().First(s => s.Name == "lata");
            //Console.WriteLine(R4.Name + " " + R4.Branch);


            //var R5 = Student.GetStudents().FirstOrDefault(s => s.Name == "lata");
            //Console.WriteLine(R5.Name + " " + R5.Branch);

            int N = Student.GetStudents().FindIndex(s => s.Name == "Mayur");
            Console.WriteLine("Position of lata in the list  is " + N);
            
            List<Student> studlist = Student.GetStudents();


            studlist.RemoveAt(N);
            foreach(Student st in studlist)
            {
                Console.WriteLine(st.Name);
            }





        }
    }
}
