using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection(@"Persist Security Info = True; data source = localhost\SQLEXPRESS;User= anikev;Password = 1; initial catalog = LearnDb");
            con.Open();
    









            //const string providerName = "System.Data.SqlClient";
            //const string serverName = @"localhost\SQLEXPRESS;";
            //string databasePach
        }
    }  
}
