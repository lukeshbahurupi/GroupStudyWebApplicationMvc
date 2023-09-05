using GroupStudyWebApplicationMvc.Models;
using GroupStudyWebApplicationMvc.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GroupStudyWebApplicationMvc.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            Employee1 Obj = new Employee1()
            {
                EmployeeId = 100,
                Name = "Manoj",
                Gender = "Male",
                City = "Pune",
                Salary = 200000,
                Address = "PCMC"
            };
            Employee1 employee = new Employee1()
            {
                EmployeeId = 101,
                Name = "Lukesh",
                Gender = "Male",
                City = "Amravati",
                Salary = 100000,
                Address = "Rukhmini Nagar"
            };

            EmployeeBusinessLayer GetInfo = new EmployeeBusinessLayer(); 

            //Employee employee = GetInfo.GetEmployeeDetails(1001);

            //ViewData["Employee"] = employee;
            //ViewData["Header"] = "Employee Details";

            //ViewBag.Employee1 = employee; 
            //ViewBag.Header1 = "Employee Details";

            GetInfo.employee1 = Obj;
            GetInfo.employee2 = employee;


            return View(GetInfo);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}