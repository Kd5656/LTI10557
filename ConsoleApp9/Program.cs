using System;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car("odi", 5, "m15", "black", 80);
            c1.showSpeed();
            c1.showColor();

        }
    }
}
