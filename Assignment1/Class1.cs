using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    enum Department { IT,Accounts,Civil,Sales,HR,Electrical}

    internal class Class1
    {
        int empid;
        string firstname;
        string lastname;
        decimal salary;
        DateTime doj;
        Department dept;

        public Class1()
        {
            empid = 1;
            firstname = "Karishma";
            lastname = "Dhamale";
            salary = 10000;
            doj= DateTime.Now;
            dept = Department.Accounts;
        }
        public Class1(int id,string firstname,string lastname,decimal salary,DateTime d,Department dt)
        {
            this.empid = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.salary = salary;
            doj = d;
            this.dept= dt;  
        }

        public override string ToString()
        {
           return "Employee Details are:"+empid+"Name:"+firstname+""+lastname+"\n Salary:"+salary+"\n"+doj.ToString()+"\n";
        }
    }
}
