using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    internal class book
    {

        public int year;
        public string name;
        public decimal price;

        public book()
        {
            year = 2013;
            name = "C";
            price = 10;
        }


        public book(int year, string name, decimal price)
        {
            this.year = year;
            this.name = name;
            this.price = price;
        }



    }
}
