using System;
using System.Collections.Generic;
using System.Text;

namespace ConsleApp_HInheritance
{
    class Rectangle : Shape
    {
        public int Lenght{ get; set; }
        public int   Breadth { get; set; }


        public Rectangle(int lenght, int breadth,string color , int sides=2):base(sides,color)
        {
            Lenght = lenght;
            Breadth = breadth;
            Color = color;
        }   

        public virtual void Area()
        {
            Console.WriteLine("Area of Rectangle=="+Lenght*Breadth);
            Console.WriteLine( "Color of Rectangle="+Color);
           
        }
    }
}
