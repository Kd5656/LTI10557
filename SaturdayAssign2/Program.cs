using System;

namespace SaturdayAssign2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("KArishma", 50500);
            e1.ShowGrossSalary();
            Manager m1 = new Manager("Meena",533);
            Employee e2 = m1;
            m1.ShowGrossSalary();
            
        }
    }
}
