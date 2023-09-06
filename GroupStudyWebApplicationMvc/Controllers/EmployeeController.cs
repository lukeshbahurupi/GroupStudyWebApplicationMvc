using GroupStudyWebApplicationMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GroupStudyWebApplicationMvc.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeDBContext dBContext { get; set; }

        public EmployeeController()
        {
            dBContext = new EmployeeDBContext();
        }
        // GET: Employee
        public ActionResult Index(int? id)
        {
            //EmployeeDBContext dBContext = new EmployeeDBContext();

            List<Employee> empList = dBContext.Employees.Where(el => el.DepartmentId == id).ToList();
            return View(empList);
        }
        public ActionResult Details(int? id)
        {

            //EmployeeDBContext dBContext = new EmployeeDBContext();

            Employee Obj = dBContext.Employees.FirstOrDefault(el => el.EmployeeId == id);

            return View(Obj); 
        }
    }
}