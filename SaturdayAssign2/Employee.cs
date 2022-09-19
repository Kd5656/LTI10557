using System;
using System.Collections.Generic;
using System.Text;

namespace SaturdayAssign2
{
    internal class Employee
    {
       public string Name { get; set; }
      public double basic_Sal { get; set; } 

        public Employee(string name,double bsal)
        {
            Name = name;    
            basic_Sal = bsal;
        }
        public void ShowGrossSalary()
        {
            double gross = basic_Sal + (basic_Sal*0.7)+ 500;
            Console.WriteLine("Gross Salary of Employee      " + Name + "is   :" + gross);
        }

    }
}
