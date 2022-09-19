using System;

namespace CogensoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithemeticFunctions(9, 3);
            Sarita("Good Morning");
            GetDetails("Karishma", 22, "Associate Trainee");
            InterestAmount(500, .15m, 4);

        }
        public static void ArithemeticFunctions(int a, int b)
        {
            Console.WriteLine("{0}+{1}={2}", a, b, a + b);
            Console.WriteLine("{0}-{1}={2}", a, b, a - b);
            Console.WriteLine("{0}*{1}={2}", a, b, a * b);
            Console.WriteLine("{0}/{1}={2}", a, b, a / b);
        }
        public static void InterestAmount(decimal amount,)
        public static void Sarita(String s)
        {
            Console.WriteLine(s);
        }
        public static void GetDetails(string name, int age, string designation)
        {

            Console.WriteLine(" Name :" + name + " Designation :" + designation + " Age :" + age);

        }

    }
}
