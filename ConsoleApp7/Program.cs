using System;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {     
            book b1 = new book();
            book b2 = new book(2022, "Coding", 120.00m);
            Console.WriteLine("year :" + b2.year + " " + "Name :" + b2.name + " " + "price :" + b2.price);
            Console.WriteLine("year :" + b1.year + " " + "Name :" + b1.name + " " + "price :" + b1.price);

        }
    }
}
