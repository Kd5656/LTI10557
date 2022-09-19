using System;
using System.Collections;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            Student[] student = new Student[4];
            student[0] = new Student() { rollno = 1, name = "Karishma"};
            student[1] = new Student() { rollno = 3, name = "monika" };
            student[2] = new Student() { rollno = 5, name = "Geeta" };
            student[3] = new Student() { rollno = 7, name = "sanika" };
            

            Student s1 = new Student() { rollno = 1, name = "mina" };
            Student student1 = new Student() { rollno = 2, name = "radhika" };
            Student s2 = student1;
                     
            int output= s1.CompareTo(s2);

           
            Console.WriteLine("Output of comparison...s " + output);

            foreach(Student s in student)
            {
                Console.WriteLine(s.rollno + " " + s.name);
            }
          */

            int[] arr = new int[] { 1, 9, 6, 7, 5, 9 };

            // Sort array in ascending order.
            Array.Sort(arr);
            Console.WriteLine("Ascending: ");
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }

            // reverse array
            Array.Reverse(arr);
            Console.WriteLine("\n\nDescending: ");
            // print all element of array
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }
        }
    }
}

