using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Point P = new Point();


            //Circle c1 = new Circle(5,0, 2);

            //Console.WriteLine("circle detais are :\nRadius :"+c1.radius+"\n cordinates:"+c1.X+","+c1.Y);
            Cylinder cy = new Cylinder();
            Cylinder cy2 = new Cylinder(23, 5, 2, 6);
            Console.WriteLine(" the cylinder details are :\n Height :" + cy.height + "\nRadius: " + cy.radius + "\n cordinates: " + cy.X + ", " + cy.Y);
            Console.WriteLine(" the cylinder details are :\n Height :" + cy2.height + "\nRadius: " + cy2.radius + "\n cordinates: " + cy2.X + ", " + cy2.Y);


        }
    }
}
