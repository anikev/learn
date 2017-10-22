using System;
using System.CodeDom;
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
            GetConnect();
            Console.WriteLine("Connect cucess!");

            Console.WriteLine("1 - Добавить данные из класса SampleEmployee");
            Console.WriteLine("2 - Выборка данных List<>");
            Console.WriteLine("3 - Выборка данных linq");
            int caseSwitch = 1;
            switch (caseSwitch)
            {
                case 1:
                    AddEmployee();
                    break;
                case 2:
                    GetDataList();
                    break;
                case 3:
                    GetDataLinq();
                    break;
                case 4:
                    Test();
                    break;
                    
            }
         Console.ReadKey();
        }
    static void AddEmployee()
        {
            using (var context = new dbContext())
            {
                SampleEmployee progr = new SampleEmployee();
                context.Employees.AddRange(progr.programmers);
                context.SaveChanges();
            }
        }
        static void GetDataLinq()
        {
            using (var context = new dbContext())
            {
                var listOfEmp = from ls in context.Employees select ls;

                foreach (var s in listOfEmp)
                {
                    Console.WriteLine(s.Name);
                }
            }

            Console.WriteLine("Запрос был выполнен инициализацией linq");
        }
        static void GetDataList()
         {
            using (var context = new dbContext())
            {

                SampleEmployee progr = new SampleEmployee();

                List<Employee> list = progr.programmers.ToList();

                foreach (Employee ofList in list)
                {
                    Console.WriteLine("\t" + ofList.Name + "\t" + ofList.Department + "\t" + ofList.JobTitle);
                }
                Console.WriteLine("Запрос был выполнен инициализацией List");
            }
        }
        static void GetConnect()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["dbContext"].ConnectionString;
            var con = new SqlConnection(connectionString);
            con.Open();
            
        }
        static void EraseData()
        {
            using (var context = new dbContext())
            {
                
            }
        }

        static void Test()
        {
            
        }

       
    }

}