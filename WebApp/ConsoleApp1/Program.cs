using System;
using System.Collections.Generic;
using System.Configuration;
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
            using (var context = new dbContext())
            {
                GetConnect();
                Console.WriteLine("Connect cucess!");
                SampleEmployee progr = new SampleEmployee();
                

                context.Employees.AddRange(progr.programmers);
                context.SaveChanges();
            }
        

           
        }

        static void GetConnect()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["dbContext"].ConnectionString;
            var con = new SqlConnection(connectionString);
            con.Open();
            Console.WriteLine("ConnectionString: {0}",
                    con.ConnectionString);
        }

       
    }

}