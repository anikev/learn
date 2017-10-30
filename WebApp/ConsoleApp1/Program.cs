using System;
using System.CodeDom;
using System.Collections;
using System.Configuration;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            BuildConnectionString();

            for (int i = 0; i < 10; i++)
            {
                Switch();
            }
           
            


        }

        static void Switch()
        {
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
            Console.Clear();
        }

        static void Test()
        {
            using (var context = new AppDbContext())
            {
                IQueryable<Employee> emp = context.Employees;
                IQueryable<Department> dep = context.Departments;

                //var ListofEmp = emp.Join(dep, e => e.Department, d => d.Id,
                //    (e, d) => new {name = e.Name, department = d.Name}
                var ListofEmp = emp.Where(e =>e.Id == 1 );
                foreach (var employees in ListofEmp)
                { 
                    Console.WriteLine(employees.Name);
                }
                 
                Console.WriteLine("Конец");
            }
        }

        static void AddEmployee()
        {
            SampleEmployee Staff = new SampleEmployee();
            Staff.AddEmp();
            Console.WriteLine("Успешно");


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
                    Console.WriteLine("\t" + ofList.Name + "\t" + ofList.Department.Name + "\t" + ofList.JobTitle);
                }
                Console.WriteLine("Запрос был выполнен инициализацией List");
            }
        }

        private static void BuildConnectionString()
        {
            ConnectionStringSettings settings =
                ConfigurationManager.ConnectionStrings["dbContext"];

            if (null != settings)
            {

                string connectString = settings.ConnectionString;

                SqlConnectionStringBuilder builder =
                    new SqlConnectionStringBuilder(connectString);

                builder.DataSource = Environment.MachineName + @"\SQLEXPRESS";

                var con = new SqlConnection(builder.ConnectionString);
                con.Open();
            }
        }

        //static void GetConnect()
        //{
        //    ConnectionStringSettings settings =
        //        ConfigurationManager.ConnectionStrings["dbContext"];
        //    string connectString = settings.ConnectionString;
        //    SqlConnectionStringBuilder builder =
        //        new SqlConnectionStringBuilder(connectString);
        //    builder.DataSource = "dfff";




        //var con = new SqlConnection(connectString);
        //    con.Open();
    }
}

    

    



