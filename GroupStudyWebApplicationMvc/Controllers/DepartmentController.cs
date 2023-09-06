using GroupStudyWebApplicationMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GroupStudyWebApplicationMvc.Controllers
{
    public class DepartmentController : Controller
    {
        private EmployeeDBContext dBContext { get; set; }
        public DepartmentController()
        {
            dBContext = new EmployeeDBContext();
        }
        // GET: Department
        public ActionResult Index()
        {
            //List<Department> List = dBContext.Departments.ToList();

            return View(dBContext.Departments.ToList());
        }
    }
}