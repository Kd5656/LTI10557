using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleAppOOPS
{
    internal class MethodOverloading
    {
        public void Add(int a,int b)
        {
            int c = a + b;
            Console.WriteLine("Addition of two numbers is" + c);
        }
        public void Add(int a,int b,int c)
        {
            c = a + b;
            Console.WriteLine("Additon of two numbers is" + c);
        }

    }
}
