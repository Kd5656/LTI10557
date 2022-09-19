using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ConsoleApp9
{
    abstract class Vehicle
    {

        public string color { get; set; }   
        public int speed { get; set; }  
        
        public Vehicle(string color,int speed)
        {
            this.color = color; 
            this.speed = speed;
        }
        abstract public void showSpeed();


        public  void showColor()
        {
            Console.WriteLine("the Color of the is" + color);
        }
  
    }

}
