using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    internal class Point
    {
        public int X { get; set; }

        public int Y { get;set;}
        
        public Point()
        {
            X = 10;
            Y = 20;

        }
        public Point(int a,int b)
        {
            X = a;
            Y = b;
        }
    }

}
