using System.Collections.Generic;

namespace ConsoleApp1
{
    class SampleEmployee
    {
        public List<Employee> Programmers = new List<Employee>{
            new Employee
            {
                Name = "Токмаков Владимир Александрович",
                Department = "АСУ",
                JobTitle = "Программист"
            },
            new Employee
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
