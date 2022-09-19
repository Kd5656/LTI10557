using System;
using System.Collections.Generic;
using System.Text;

namespace ConsleApp_HInheritance
{
    internal class Triangle:Shape
    {
        public int base1 { get; set; }
        public int height { get; set; }  

        public Triangle(int bs, int ht, string color, int sides = 2) : base(sides, color)
        {
            base1 = bs;
            height = ht;
            Color = color;
        }
        public void Area()
        {
            Console.WriteLine("Area of Triangle is=" + (0.5 * base1 *height));
            Console.WriteLine("Color of Triangle is==" + Color);

        }
    }
}
