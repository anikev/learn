using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            AppdbContext db = new AppdbContext();
            {
                var emp = db.Employees.ToList();
                var dep = db.Departments.ToList();

                var s = emp.Join(dep, e => e.Department, d => d.Id, (e, d) => new { de= dep, });
                foreach (var c in s)
                {
            
                }

                // ViewBag.Employee
            }

            return View();
        }
    }
}