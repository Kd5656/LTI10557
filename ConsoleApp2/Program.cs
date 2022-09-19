using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = DateTime.Now;
            Console.WriteLine(d.ToString());
            Console.WriteLine(d.Date);
            Console.WriteLine(d.Hour);
            Console.WriteLine(d.Minute);
            Console.WriteLine(d.Second);    
            Console.WriteLine(d.Millisecond);
            Console.WriteLine(d.Day);
            Console.WriteLine(d.DayOfWeek);
            Console.WriteLine(d.Month); 
            Console.WriteLine(d.Year);
            Console.WriteLine(d.DayOfYear);
            Console.WriteLine(d.TimeOfDay);

            Console.WriteLine("Hello world");
            var dt = new DateTime(2016, 5, 5);
            Console.WriteLine(dt.ToString());
            var time = new DateTime(1, 1, 12, 13, 13, 13);
            Console.WriteLine(time.ToString());
            var combineDateTime = dt.AddTicks(time.TimeOfDay.Ticks);
            Console.WriteLine(combineDateTime.ToString());

        }
    }
}
