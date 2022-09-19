using System;
using System.Collections.Generic;
using System.Text;

namespace SturdayProj2
{
    internal class Mother
    {
        string Mname;
        int mage;


        public Mother()
        {
            Mname = "Geeta";
            mage = 45;
        }
        public override string ToString()
        {
            return "Mother _Details are" + Mname + "" + mage;
        }
    }
}
