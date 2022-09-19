using System;
using System.Collections;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();
            a.Add(1);
            a.Add(2);
            a.Add(3.50m);
            a.Add(3.480f);
            a.Add(Math.PI);
            a.Add("L and T");
            a.Add(DateTime.Now);
            Console.WriteLine(a.ToString());  
            foreach(var obj in a)
            {
                Console.WriteLine(obj);
;            }
            //there is a process of boxing
            //value type or any type converted to object type


            Console.WriteLine();    
            //converting object type to its original value type:unboxing



        }
    }
}
