using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmpProfileApp.Models;
namespace EmpProfileApp.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        static List<EmpProfile> empProfiles = new List<EmpProfile>
        {
            new EmpProfile{EmpCode=100,EmpName="Scott",Email="scott@gmail.com" },
            new EmpProfile{EmpCode=101,EmpName="Tiger",Email="tiger@gmail.com"},
            new EmpProfile{EmpCode=102,EmpName="Smith",Email="smith@gmail.com" },
            new EmpProfile{EmpCode=103,EmpName="Adam",Email="adam@gmail.com"}
        };
        public ActionResult EmployeeList()
        {
            return View(empProfiles);
        }
    }
}