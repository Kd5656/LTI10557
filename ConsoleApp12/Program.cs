using System;
using System.Collections;
using System.Security.Cryptography;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Stack k = new Stack();
            k.Push(12);
            k.Push("Sarika");
            k.Push(12.8f);
            try
            {
                Console.WriteLine(k.Pop());
                Console.WriteLine(k.Pop());
                Console.WriteLine(k.Pop());
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);   
            }
            Queue queue = new Queue();
            queue.Enqueue("A");
            queue.Enqueue("B"); 
            queue.Enqueue(123);
            queue.Enqueue("Sarita");
            queue.Enqueue(DateTime.Now.ToShortDateString());
            Console.WriteLine(queue.Dequeue());
            Hashtable ht = new Hashtable();
            ht.Add(1, "one");
            ht.Add(2,"two");
            ht.Add(3, null); 
            ht.Add(4, "four");  
            Console.WriteLine(ht.ToString());
                       Person[] student = new Person[4];
            student[0] = new Person() { rollno = 1, name = "Karishma" };
            student[1] = new Person() { rollno = 3, name = "monika" };
            student[2] = new Person() { rollno = 5, name = "Geeta" };
            student[3] = new Person() { rollno = 7, name = "sanika" };

 
            foreach (Person s in student)
            {
                Console.WriteLine(s.rollno + " " + s.name);
            }
            */


            int[] arr = new int[5];
            arr[0] = 1;
            arr[1] = 5;
            arr[2] = 8;
            arr[3] = 0;
            arr[4] = 2;
            arr[5] = 1; 
            Array.Reverse(arr);
           (Array k in arr)
            {
                Console.WriteLine(k.ToString());    
            }


        }
    }
}
