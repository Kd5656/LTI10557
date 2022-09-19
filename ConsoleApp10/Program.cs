using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car mycar = new Car() { model = "bchd", brand = "vfnj", noofseats = 7,ManufactureYear =2022};
           mycar.Print();
            mycar.showDate();
            ;
        }
    }
}
