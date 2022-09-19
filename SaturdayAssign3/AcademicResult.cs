using System;
using System.Collections.Generic;
using System.Text;

namespace SaturdayAssign3
{
    internal class AcademicResult : Student
    {
   
        int m1, m2, m3;
       
        public AcademicResult(int m1, int m2, int m3,int id,string name,string address):base(id,name,address)
        {
            this.m1 = m1;
            this.m2 = m2;
            this.m3 = m3;
        }   
        public void DisplayAcademicResult()
        {
            double avg = (m1 + m2 + m3) / 3;
            Console.WriteLine("Marks of Subject is as follow:   \n1.Physics= " + m1 + "\n2 Chemistry= " + m2 + "\n3 Maths=" + m3);
            Console.WriteLine("Average Marks of Students are===" + avg);
        }
    }
}
