using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading;

namespace HomeAssignment1
{    enum Category { A,B,C,D,E};
    internal class Medicine
    {
        int mid;
        string medname;
        string meduse;
        double price;
        DateTime doj;
        Category category1;
        static int count;


        static Medicine()
        {
            count = 100;
            Console.WriteLine("This is static constructor");
        }
        public Medicine()
        {
            mid = 52;
            medname = "Strep sills";
            meduse = "Cough";
            price = 25.20f;
            doj=new DateTime(2022,5,15);
            category1 = Category.A;
            count++;
            Console.WriteLine("This is a Defualt Constructor");

        }
        
        public Medicine(int id, string medname, string meduse, double p, DateTime dt, Category category)
        {
            Console.WriteLine("This is  a Parametrized Constructor");
            mid = id;
            this.medname = medname;
            this.meduse = meduse;
            this.price = p;
            doj = dt;
            category1 = category;
            count++;
        }
        public static void ShowCount()
        {
            Console.WriteLine("Total no of medicines are=" + count);
        }
       

        public override string ToString()
        {
            return "\n The Medicine Details are as follow==:\n Medicine Id=" + mid + "\n Medicine Name=" + medname + "\n Medicine Use=" + medname +
                "\n Medicine Price=" + price + "\n Medicine Date of Expiry=" + doj.ToString() + "\n Medicine Category=" + category1;
        }

    }
}
