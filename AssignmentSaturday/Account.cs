using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentSaturday
{ enum Category { Deposit,Withdrawl}
    internal class Account
    {
        int accno;
        string accname;
        decimal balance;
        Category category;


        public Account()
        {
            accno = 10123654;
            accname = "Harshal Jadhav";
            balance = 7265;
            category = Category.Deposit;    
        }

        public Account(int accno, string accname, decimal balance, Category category)
        {
            this.accno = accno;
            this.accname = accname;
            this.balance = balance;
            this.category = category;
        }
        public override string ToString()
        {
            return "The Bank Details are as follow \n The Account no=="+accno + "+\n The account holder name== " + accname + 
                "\n The account balance is " + balance + "\n The account category is= " + category;  
        }
    }
}
