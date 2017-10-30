using System;
using System.Collections.Generic;

namespace WebApp.Controllers
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string JobTitle { get; set; }
       public DateTime? EmploymentDateFrom { get; set; }
        public string TestField { get; set; }
        public int? Skill { get; set; }

        public virtual Department Department { get; set; }

        

    }
    
    
}
