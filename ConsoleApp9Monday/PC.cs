using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9Monday
{
    internal class PC : Computers
    {
        string keyboard;
        string monitor;
        string mouse;


        
        public PC(string keyboard, string monitor, string mouse,string displays,string circuits,string motherboard,string ram):base(motherboard,ram,circuits,displays)
        {
            this.keyboard = keyboard;
            this.monitor = monitor;
            this.mouse = mouse; 
        }
    }
}
