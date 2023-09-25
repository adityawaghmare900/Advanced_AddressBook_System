using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateDataBase_UC1
{
    public  class CustomerOperation
    {
        public static void createDB()
        {
            SqlConnection con = new SqlConnection("data source=(localdb)\\MSSQLLocalDB; initial catalog=master; integrated security=true");

            //write sql query
            string query = "create database Advanced_Address_Book_Service";
            SqlCommand cmd= new SqlCommand(query, con);
             
            //opening connection
            con.Open();
            cmd.ExecuteNonQuery();
            Console.WriteLine("Database created Successfully");
            Console.WriteLine("=============================");

            con.Close();

        }
    }
}
