using System.Collections.Generic;

namespace ConsoleApp1
{
    class SampleEmployee
    {
        public void AddEmp()
        {
            using (var context = new AppDbContext())
            {

                Department dept = new Department { Name = "АСУ" };
                context.Departments.Add(dept);
                Employee emp = new Employee { Department = dept, Name = "Аникьев П.А." };
                context.Employees.Add(emp);


            }
                
        }
    }
}
