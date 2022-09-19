using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ConsoleApp16AdoNet
{
    internal class Program1
    {
        static void Main(String[] args)
        {

            try
            {
                SqlConnection con = new SqlConnection("Data Source=Karishma;Initial Catalog=LTI;Integrated Security=True");

                SqlCommand com = new SqlCommand();

                com.Connection = con;

                com.CommandText = "insert into Student1(id,Name,Marks)values(@id,@Name,@Marks)";
                SqlParameter p1 = new SqlParameter("@id", SqlDbType.Int);
                Console.WriteLine("Enter id of student");
                int id = Convert.ToInt32(Console.ReadLine());
                p1.Value = id;
                com.Parameters.Add(p1);

                SqlParameter p2 = new SqlParameter("@Name", SqlDbType.VarChar);
                Console.WriteLine("Enter name of student");
                string Name = Console.ReadLine();
                p2.Value = Name;
                com.Parameters.Add(p2);

                SqlParameter p3 = new SqlParameter("@Marks", SqlDbType.Int);
                Console.WriteLine("Enter name of student");
                int Marks = Convert.ToInt32(Console.ReadLine());
                p3.Value = Marks;
                com.Parameters.Add(p3);

                con.Open();
                com.ExecuteNonQuery();



                Console.WriteLine("Record Added Successfully");



            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
