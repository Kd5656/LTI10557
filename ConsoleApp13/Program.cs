using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int , string> dt = new SortedDictionary<int , string>();
            dt.Add(1, "USA");
            dt.Add(2, "India");
            dt.Add(3, "Russia");
            dt.Add(4, "JApan");
            dt.Add(5, "korea");
            dt.Add(6, null);
            Console.WriteLine(dt.ContainsKey(7));
            Console.WriteLine(dt.ContainsValue("Singapore"));
            Console.WriteLine(dt.Count);
            Console.WriteLine(dt.ContainsKey(8));
            Console.WriteLine(dt.ContainsKey(3));   


        }
    }
}
