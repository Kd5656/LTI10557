using System;
using System.Collections.Generic;

namespace GenericCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //synatx List<T> nameoflist = new <T> ();
            List<string> fruits=new List<string>();
            fruits.Add("Mango");
            fruits.Add("LIme");
            fruits.Add("apple");
            fruits.Add("Banana");
            fruits.Add("Orange");
            Console.WriteLine("unsorted list");
            foreach(string f in fruits)
            {
                Console.WriteLine(f);
            }
            fruits.Sort();
            foreach(string k in fruits)
            {
                Console.WriteLine(k);
            }

            
        }
    }
}
