using GroupStudyWebApplicationMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupStudyWebApplicationMvc.ViewModels
{
    public class EmployeeBusinessLayer
    {
        public Employee1 employee1 { get; set; }
        public Employee1 employee2 { get; set; }
        public Employee1 GetEmployeeDetails(int EmpId)
        {
            Employee1 employee = new Employee1()
            {
                EmployeeId = EmpId,
                Name = "Lukesh",
                Gender = "Male",
                City = "Amravati",
                Salary = 100000,
                Address = "Rukhmini Nagar"
            };
            return employee;
        }
    }
}