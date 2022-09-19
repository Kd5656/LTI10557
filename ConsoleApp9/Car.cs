using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    internal class Car : Iprintable
    {
        public string brand { get; set; }   
         public int noofseats { get; set; }  

         public string model { get; set; }

        /* public Car(string brand, int noofseats, string model,string color,int speed):base(color,speed)
         {
             this.brand = brand;
             this.noofseats = noofseats;
             this.model = model;
         }   

         public override void showSpeed()
         {
             Console.WriteLine("Speed of car is" + speed);

         }*/

        public void Print()
        {
            Console.WriteLine("Brand: " + brand + "Model: " + model + "no os seats:  " + noofseats);
        }
        public void showDate()
        {
            int dt = DateTime.Now.Year;
            Console.WriteLine("Manufacture year is" + dt);
        }

        public Car()
        {
        }
    }
}
