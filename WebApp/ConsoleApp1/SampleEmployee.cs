using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ConsoleApp1
{
    public class SampleEmployee : DropCreateDatabaseAlways<AppDbContext>
    {
        public void AddEmp()
        {
            using (var context = new AppDbContext())
            {
                List<Department> dept = new List<Department>
                {
                    new 
                        Department {Name = "АСУ"},
                    new
                        Department {Name = "Отдел кадров"},
                    new
                        Department {Name = "Планово-экономический отдел"},
                    new
                        Department {Name = "Расчетый отдел"}
                };

                context.Departments.AddRange(dept);
                context.SaveChanges();

                var Staff = new List<Employee>
                {
                    new
                        Employee {Name = "Аникьев Петр Александрович",Department = dept.Find(d =>d.Name == "АСУ")},
                    new
                        Employee {Name = "Гамерв Сергей Александрович",Department = dept.Find(d =>d.Id == 4)},
                    new 
                        Employee {Name = "Токмаков Владимир Александрович"}
                };
                context.Employees.AddRange(Staff);
                context.SaveChanges();
            }
            ;
        }
    }
}

