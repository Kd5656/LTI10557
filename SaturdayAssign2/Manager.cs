using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SaturdayAssign2
{
    internal class Manager : Employee
    {
        public string Name { get; set; }
        public double basic_Sal { get; set; }
        public Manager(string name, double bsal) : base(name, bsal)
        {
            Name=name;
            basic_Sal=bsal; 
        }

        public new void ShowGrossSalary()
        {
            base.ShowGrossSalary();
     
        }

    }
}
