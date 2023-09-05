﻿using GroupStudyWebApplicationMvc.Models;
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
        public ActionResult Index()
        {
            //EmployeeDBContext dBContext = new EmployeeDBContext();

            List<Employee> empList = dBContext.Employees.ToList();
            return View(empList);
        }
        public ActionResult Details(int id)
        {

            //EmployeeDBContext dBContext = new EmployeeDBContext();

            Employee employee = dBContext.Employees.FirstOrDefault(el => el.EmployeeId == id);

            return View(employee); 
        }
    }
}