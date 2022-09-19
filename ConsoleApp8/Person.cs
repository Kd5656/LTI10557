using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    internal class Person
    {
       public  string name;
        public string address;

        public Person()
        {
            name = "Karishma";
            address = "Tathawde";
        }
        public Person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }   
    }
}
