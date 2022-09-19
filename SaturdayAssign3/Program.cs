using System;

namespace SaturdayAssign3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student S = new Student(101, "HarshadvDhamale", "Pune");
            S.Display();
            AcademicResult A = new AcademicResult(85, 89, 96, 101, "Pinky", "pune");
            A.DisplayAcademicResult();
        }
    }
}
