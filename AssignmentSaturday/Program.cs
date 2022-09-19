using System;

namespace AssignmentSaturday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account();
            Console.WriteLine(a1);
            Account a2 = new Account(15235422, "Neha Sharma", 532, Category.Withdrawl);
            Console.WriteLine(a2);
        }
    }
}
