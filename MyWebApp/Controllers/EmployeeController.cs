using KuasCore.Models;
using KuasCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyWebApp.Controllers
{
    public class EmployeeController : ApiController
    {
        public IEmployeeService EmployeeService { get; set; }

        [HttpGet]
        
        public IList<Employee> GetEmployees()
        {
            
            return EmployeeService.GetAllEmployees();
        }

        [HttpPost]
        public Employee AddEmployee(Employee employee)
        {
            
            try
            {
                EmployeeService.AddEmployee(employee);
                return EmployeeService.GetEmployeeById(employee.Id);
            }
            catch (Exception)
            {
                throw new HttpResponseException(HttpStatusCode.InternalServerError);
            }
        }

        //[HttpGet]

        //public Employee GetEmployeeById(string id)
        //{
        //   return EmployeeService.GetEmployeeById(id);

        //}
        [HttpGet]

        public Employee GetEmployeeByName(string name)
        {
            return EmployeeService.GetEmployeeByName(name);

        }
    }
}
