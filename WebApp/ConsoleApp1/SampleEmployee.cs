using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class SampleEmployee
    {
        public void AddEmp()
        {
            using (var context = new AppDbContext())
            {

                
                //Employee emp = new Employee { Department = dept, Name = "Аникьев П.А." };
                //context.Employees.Add(emp);
                //context.SaveChanges();
                //Console.WriteLine("Добавили" + emp.Name);
                Department dept = new Department { Name = "АСУ" };
                context.Departments.Add(dept);
                context.SaveChanges();
                Console.WriteLine("Добавили" + dept.Name);


            }
                
        }
    }
}
