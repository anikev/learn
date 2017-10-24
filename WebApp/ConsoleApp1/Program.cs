using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;

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
            Console.WriteLine("4 - Запуск процедуры Test()");
            string caseSwitch = Console.ReadLine();
            switch (int.Parse(caseSwitch))
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
            
            Console.ReadLine();
        }

        static void AddEmployee()
        {
            using (var context = new AppDbContext())
            {
                var progr = new SampleEmployee();
                
                progr.AddEmp();
                context.SaveChanges();
                Console.WriteLine("Успешно");
            }
        }

        static void GetDataLinq()
        {
            using (var context = new AppDbContext())
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
            using (var context = new AppDbContext())
            {
                var lisfOfProgrammers = context.Employees.ToList();
                foreach (Employee ofList in lisfOfProgrammers)
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

       

        static void Test()
        {
            using (var context = new AppDbContext())
            {
                var emp = new Employee();
                var listOfProgr = from ls in context.Employees
                                  select ls;
                foreach (var list in listOfProgr)
                    Console.WriteLine(list);

            }
        }

    }
}


