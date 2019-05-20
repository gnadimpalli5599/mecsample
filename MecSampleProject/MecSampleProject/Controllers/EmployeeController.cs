using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MecSampleProject.Models;
using MecSampleProject.Business;
namespace MecSampleProject.Controllers
{
    public class EmployeeController : ApiController
    {
        //   IEmployeeBusiness _emp = new EmployeeBusiness();
        private IEmployeeBusiness _employeeBusiness;
        public EmployeeController(IEmployeeBusiness employeeBusiness)
        {
            _employeeBusiness = employeeBusiness;
        }
        public IList<Employee> GetAllEmployees()
        {
            string _mess = "working";

            CustomLogging.LogMessage(CustomLogging.Trace.INFO, _mess);
            return _employeeBusiness.GetEmployeeList();
        }


    }
}

