using System;
using System.CodeDom;
using System.Collections;
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
                //SampleEmployee progr = new SampleEmployee();
                IQueryable<Employee> fggg = context.Employees;
                //List<Employee> list = Emp.ToList();
                fggg = fggg.Where(f => f.Name.StartsWith("а"));

                foreach (var ofList in fggg)
                {
                    Console.WriteLine(ofList.Id + "\t" + ofList.Name + "\t" + ofList.Department + "\t" + ofList.JobTitle);
                }
                Console.WriteLine("Запрос был выполнен инициализацией List");
                Console.ReadKey();
                string str = "";
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

            static void EraseData()
            {
            }

            static void Test()
            {
                using (var context = new dbContext())
                {
                    Employee emp = new Employee();
                    var listOfProgr = from ls in context.Employees
                        select ls;

                    foreach (var list in listOfProgr)
                    {
                        Console.WriteLine(list);
                    }
                }
            }
        }
    }