using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_Table_UC2
{
    internal class CreateOperations
    {
        public static SqlConnection con = new SqlConnection("data source=(localdb)\\MSSQLLocalDB; initial catalog=Advanced_Address_Book_Service; integrated security=true");
        public static void createDB()
        {
            SqlConnection con = new SqlConnection("data source=(localdb)\\MSSQLLocalDB; inital catalog=master; integrated security=true");
            //write sql query
            string query = "create database Advanced_Address_Book_Service";
            SqlCommand cmd = new SqlCommand(query, con);

            //opening connection
            con.Open();
            cmd.ExecuteNonQuery();
            Console.WriteLine("Database created Successfully");
            Console.WriteLine("=============================");

            con.Close();

        }

        public static void createTable()
        {
            string query = "create table CustomerData(Id int primary key identity(1,1),Name varchar(200), LastName varchar(200), address varchar(200), city varchar(100), state varchar(100), zipcode int, phonenumber int, email varchar(50))";

            SqlCommand cmd= new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            Console.WriteLine("table inserted successfully");
            con.Close() ;
        }
    }
}
