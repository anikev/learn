using System;

namespace ConsoleApp1
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string JobTitle { get; set; }
        public string Department { get; set; }
        public DateTime? EmploymentDateFrom { get; set; }
        public string TestField { get; set; }
        


    }
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }

}
