using System;

namespace Assignment1._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the units for user");
            int units = Convert.ToInt32(Console.ReadLine());
            double result;

            if(units <100)
            {
                result=1.2*units;
                Console.WriteLine("The Electricity bill is:  " + result+"Rs");

            }
            else if(units>100 && units<=300)
            {
                result = 2*units;
                Console.WriteLine("The Electricity bill is : " + result+"Rs");

            }
            else
            {
                result = 2 * 3 * units;
                Console.WriteLine("The Electricity Bill is: "+result+"Rs");
            }
                


        }
    }
}
