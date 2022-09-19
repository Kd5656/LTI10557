using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ConsoleApp16AdoNet
{
    internal class Program3
    {
        static void Main(String[] args)
        {

            try
            {
                string connectionstr = "Data Source=Karishma;Initial Catalog=LTI;Integrated Security=True";
                //SqlConnection con = new SqlConnection("Data Source=Karishma;Initial Catalog=LTI;Integrated Security=True");

                SqlConnection con = new SqlConnection(connectionstr);
                SqlDataAdapter da = new SqlDataAdapter("select Id,name,marks from Student", con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt = new DataTable();
                dt = ds.Tables[0];
                foreach(DataRow row in dt.Rows)
                {
                    Console.WriteLine("Id=" + row[0] + "Name=" + row[1] + "MArks=" + row[2]);
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
