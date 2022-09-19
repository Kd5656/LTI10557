using System;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person("Swati","Dhamale");
            Console.WriteLine("year :" + p1.name + " " + "Name :" + p1.address);
            Console.WriteLine("year :" + p2.name + " " + "Name :" + p2.address);


        }
    }
}
