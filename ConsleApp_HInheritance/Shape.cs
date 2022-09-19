using System;
using System.Collections.Generic;
using System.Text;

namespace ConsleApp_HInheritance
{
    internal class Shape
    {
        public int Sides { get; set; }
        public string Color { get; set; }



        public void Area()
        {
            Console.WriteLine("Formula for specific shape ");
        }



        public Shape(int s, string color)
        {
            Sides = s;
            this.Color = color;
           
        }

    }
}
