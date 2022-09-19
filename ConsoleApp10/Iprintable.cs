using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    interface Iprintable
    {
        //only abstract methods and properties are herer
        //opposit to abstract class no fields here
        //no public keyword is required for method access modifier
        //why?because it is meant for public use
        void Print();
        void showDate();
        void showTime();    
    }
}
