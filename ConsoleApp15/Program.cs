using System;
using System.Collections;
using System.Linq;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Result = Student1.GetStudents().SelectMany(s=> s.Programming).Distinct();   
            

            foreach(string p in Result)
            {
                Console.WriteLine(p);
            }
        }
    }
}
