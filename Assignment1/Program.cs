using System;


namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;
            var d5 = new DateTime(2002, 5, 12);
            Class1 c1 = new Class1();
            Console.WriteLine(c1);

            Class1 c2 = new Class1(2, "Decker", "Jhonny", 80000, new DateTime(2016, 5, 12),Department.Sales);
            Console.WriteLine(c2);
                }
    }
}
