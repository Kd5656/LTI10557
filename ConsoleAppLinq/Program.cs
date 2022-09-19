using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ConsoleAppLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] numbers = { 1, 2, 3, 4, 5, 6 };

            // var result = from p in numbers
            //
            //select p;

            var result = from n in numbers
                         where n<5 && n%2==0
                         orderby n
                         select n;

            foreach(int i in result)
            {
                Console.WriteLine(i);   
            }*/
            List<string> a = new List<string>();

            a.Add("pune");
            a.Add("nagpur");
            a.Add("nashik");
            a.Add("mumbai");

            var k = from c in a
                    where c[0]=='m'//first word is m
                    select c;

           foreach(string s in k)
                Console.WriteLine(s);

            var R = a.Any(c => c.Contains("na"));
            Console.WriteLine("is there any city"+R);
            Console.WriteLine("are all cities " + a.Count);


            float[] temperature = { 25, 28, 29, 36, 25, 21, 42 };
            var ans1 = temperature.Sum();
            Console.WriteLine("sum functioning working on temperature =" + ans1);

            var ans2=temperature.Count();
            Console.WriteLine("Count of Elements" + ans2);



            Console.WriteLine("Average temperature is"+temperature.Average());
            Console.WriteLine("Average temperature is" + temperature.Max());
            Console.WriteLine("Average temperature is" + temperature.Min());


















        }
    }
}
