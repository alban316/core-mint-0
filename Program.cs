/*
 * This is a sample app connecting to a SQL instance with .NET Core. 
 * The SQL instance in this case is SQL on Linux!!
 * 
 */

using System;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=master;Integrated Security=False;User Id=sa;Password=Withersp00n;MultipleActiveResultSets=True";
            string query = @"
                SELECT *
                FROM sys.objects
                ";

            SqlConnection conn = new SqlConnection(connectionString);

            using (conn)
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine(reader.GetSqlString(0));
                }

            }
        }
    }
}
