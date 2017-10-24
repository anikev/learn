using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SampleEmployee
    {
        public List<Employee> programmers = new List<Employee>{new Employee
        {
            Name = "Токмаков Владимир Александрович",
            Department = "АСУ",
            JobTitle = "Программист"
        },new Employee
            {
                Name = "Гамеров Сергей Александрович",
                Department = "АСУ",
                JobTitle = "Программист"
            },new Employee
            {
                Name = "Жуков Тарас Игоревич",
                Department = "АСУ",
                JobTitle = "Программист"
            },new Employee
            {
                Name = "Бутяев Алексей Васильевич",
                Department = "АСУ",
                JobTitle = "Программист"
            }, new Employee
            {
                Name = "Аникьев Петр Александрович",
                Department = "АСУ",
                JobTitle = "Програмист"
            }
            
        };
    }
}
