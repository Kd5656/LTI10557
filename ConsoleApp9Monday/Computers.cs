using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9Monday
{
    internal class Computers:ElectronicDevices
    {
        string motherboard;
        string RAM;

        public Computers(string motherboard,string ram,string displays,string circuits):base(displays,circuits)
        {
            this.motherboard = motherboard;
            this.RAM = ram;
        }


    }
}
