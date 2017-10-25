using System;
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
            Database.SetInitializer(
                new DropCreateDatabaseIfModelChanges<AppDbContext>());
            
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
                

            }

            Console.ReadLine();
        }

        static void AddEmployee()
        {
            using (var context = new AppDbContext())
            {

                var dept = new Department { Name = "ИТО" };
                context.Departments.Add(dept);

                var emp = new Employee
                {
                    Name = "Аникьев", Department = dept

                };
                Console.WriteLine(emp.Name + "\t" + emp.Department);
                context.Employees.Add(emp);
                context.SaveChanges();
            }






            //Department dept = new Department { Name = "АСУ"};

            //context.Departments.Add(dept);
            //context.SaveChanges();
            //Console.WriteLine("Добавили  "  + dept.Name);


            //var progr = new SampleEmployee();

            //progr.AddEmp();
            //context.SaveChanges();
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
                    Console.WriteLine("\t" + ofList.Name + "\t" + ofList.Department + "\t" + ofList.JobTitle);
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
                
                
                var con = new SqlConnection(connectString);
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



