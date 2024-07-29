using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LINQWithDB
{

    class Program
    {
        static void Main()
        {
            string connectionString = "Server=DESKTOP-66UP5QF;Database=testDB;Integrated Security=True;";

            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            SqlCommand sqlCmd = new SqlCommand("select * from Employee",sqlConn);
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine($"Name : {reader["name"]} - Salary : {reader["salary"]}");
            }
            sqlConn.Close();
        }
    }

}
