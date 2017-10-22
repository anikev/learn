﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string JobTitle { get; set; }
        public string Department { get; set; }
        public DateTime? EmploymentDateFrom { get; set; }

        public List<Department> Departments { get; set; }

    }
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Employee Employee { get; set; }
    }

}
