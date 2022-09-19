using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    internal class Books
    {
        int id;
        string bname;
        string author;

        public Books()
        {
            id = 101;
            bname = "Snow Child";
            author = "Eowyn Ivey";
        }

        public Books(int id,string bname, string author)   
        
        {    
            this.id = id;
            this.bname = bname;
            this.author = author;
        }

    }
}
