using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace DataBaseConnectSKZ
{
    class Program 
    {
        static void Main(string[] args)
        {
            var produtos = GetProduct();

            Console.WriteLine("Hello World!");
        }

        private static IEnumerable<Product> GetProduct()
        {
            using(var connection = new SqlConnection("Server=DESKTOP-JRR030Q\SQLEXPRESS;Database=SKZTeste;Trusted_Connection=True;"))
            {
                return connection.Query<Product>("Select*from product");
            }
        }
    }
}