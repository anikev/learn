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
                
                
                

                IEnumerable<Employee> fggg2 = context.Employees;
                fggg2 = fggg2.Select(s => s);

                foreach (var ofList in fggg2)
                {
                    Console.WriteLine(ofList.Id + "\t" + ofList.Name + "\t" + ofList.Department + "\t" + ofList.JobTitle);
                }
                Console.WriteLine("Запрос был выполнен инициализацией List");
                // context.Employees.Remove();
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
            }
            Console.ReadLine();
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
        public IEnumerable GetIEnumerable()
        {
            var context = new dbContext();
            IEnumerable<Employee> fggg = context.Employees;
            var l_fggg = from fgg in fggg select fggg;
            

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
                if (l_fggg.Any) context.Employees.RemoveRange(fggg); else Console.WriteLine("БД Пуста...");
                context.SaveChanges();
            }
        }

        static void Test()
        {
            using (var context = new dbContext())
            {
                Employee emp = new Employee();
                var listOfProgr = from ls in context.Employees
                                  select ls;
                foreach (var list in listOfProgr) Console.WriteLine(list);

            }
        }

    }
}


