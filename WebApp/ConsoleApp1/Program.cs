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
                List<Employee> list = progr.programmers.ToList(); 

                foreach ( Employee ofList in list)
                {
                    Console.WriteLine("\t" + ofList.Name + "\t" +ofList.Department +"\t" + ofList.JobTitle);
                }



                Console.WriteLine("");
                Console.ReadKey();
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