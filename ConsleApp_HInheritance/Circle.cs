using System;
using System.Collections.Generic;
using System.Text;

namespace ConsleApp_HInheritance
{
    internal class Circle
    {
        public int Radius { get; set; }

        public Circle()
        {
            Radius = 10;
        }
        public Circle(int r)
        {
            Radius= r;  
        }

        public virtual  void Area()
        {
            double A = Math.PI * Radius * Radius;
            Console.WriteLine("Area of Circle:::{0:f2}", A);
        }
    }
}
