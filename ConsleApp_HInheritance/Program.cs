using System;

namespace ConsleApp_HInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Rectangle R1 = new Rectangle(12, 34, "red");
            //R1.Area();
            //Triangle t1 = new Triangle(12, 12, "pink");
            //t1.Area();
            Circle c1 = new Circle(3);
            c1.Area();
            Cylinder cy1 = new Cylinder(300, 3);
            cy1.Area();
            Circle C = cy1;//Shadowing effect
            C.Area();
            //this is an example of polymorphism
            //compile time it is decided that which class Area Function will be executed
            //so this is compile time polymorphism//
            //now lets us see the shadowing effect
        }
    }
}
