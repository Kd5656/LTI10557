using System;

namespace Swaapingandall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int x = 100;
            //int y = 10;
            // Console.WriteLine("Before Swaaping value of x="+x+"Before Swappimg value of y="+y);
            //Swap(ref x, ref y);
            // Console.WriteLine("After Swapping value of x="+x+"and value of y="+y);
            //Console.ReadKey();
            //double Ar;
            //int radius;
            //Console.WriteLine("Enter Radius");
            //radius = Convert.ToInt16(Console.ReadLine());
            //Area(ref radius,out Ar);
            //Console.WriteLine("Area of Circle={0:f2", Ar);
            int Ar;
            int l;
            int b;
            Console.WriteLine("Enter the length and breadth of Rectangle");
            l=Convert.ToInt16(Console.ReadLine());
            b=Convert.ToInt16(Console.ReadLine());
            Area(ref l, ref b, out Ar);
            Console.WriteLine("Area of Rectangle is ={0:f2}", Ar);
            Console.ReadKey();
        }
        public static void Area(ref int l,ref int b,out int A)
        {
            A = l * b;
        }

        //public static void Area(ref int r,out double A)
        //{
          //  A = Math.PI * r * r;
        //}
       // public static void Swap(ref int a,ref int b)
        //{
            //int temp = a;
            //a = b;
          //  b= temp;
            
       // }
    }
}
