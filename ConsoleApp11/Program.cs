using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
     

        static void Main(string[] args)
        {
             string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Windows10\source\repos\ConsoleApp11\ConsoleApp11\Db.mdf;Integrated Security=True";
             SqlConnection sqlConnection = null;
             SqlCommand sqlCommand = null;
             SqlDataReader reader = null;


            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            sqlCommand = new SqlCommand
            ("CREATE TABLE gruppa (Id int primary key identity, Name nvarchar(25) NOT NULL)", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            Console.ReadLine();
        }
    }
}
