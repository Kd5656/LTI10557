using System;
using System.Collections.Generic;
using System.Text;

namespace ConsleApp_HInheritance
{
    internal class Cylinder : Circle
    {
        public int height { get; set; }
        public Cylinder()
        {
            height = 100;
        }
        public Cylinder(int h, int r) : base(r)
        {
            height = h;
        }
        //new keyword can be used instead of overrride
        //this will 
        public new void Area()
        {
            double A = 2 * Math.PI * Radius * (Radius + height);
            Console.WriteLine("Area of Cylinder :{0:F2}", A);
        }
    }
}






