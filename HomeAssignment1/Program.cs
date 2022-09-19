using System;
using System.ComponentModel;
using System.Threading;

namespace HomeAssignment1
{
    internal class Program
    {
        static int count;
        static void Main(string[] args)
        {
            Medicine m1 = new Medicine();
            Console.WriteLine(m1);
            Medicine m2 = new Medicine(2, "Penicillins", "Antibiotics", 8.20f, new DateTime(2013, 12, 3), Category.C);
            Console.WriteLine(m2);
          
            Medicine[] medicine = new Medicine[5];
            medicine[0] = new Medicine(3, "Vicks", "tablet", 2.0f, new DateTime(2002, 3, 1), Category.D);
            medicine[1] = new Medicine(3, "Vicks", "tablet", 2.0f, new DateTime(2002, 3, 1), Category.D);
            medicine[2] = new Medicine(3, "Vicks", "tablet", 2.0f, new DateTime(2002, 3, 1), Category.D);
            medicine[3] = new Medicine(3, "Vicks", "tablet", 2.0f, new DateTime(2002, 3, 1), Category.D);
            medicine[4] = m2;
            Console.WriteLine("The Medicine in the array list are :::");
            foreach(Medicine m in medicine)
            {
                Console.WriteLine(m);
            }

            Medicine.ShowCount();

        }
    }
}
