using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MecSampleProject.Models;
using MecSampleProject.Data;

namespace MecSampleProject.Business
{
    public class EmployeeBusiness:IEmployeeBusiness
    {
        IEmployeeDataAccess employeeDb = null;
       
        public EmployeeBusiness()
        {
            employeeDb = new EmployeeDataAccess();
        }
        
        public List<Employee> GetEmployeeList()
        {
            return employeeDb.GetEmployeeList();
        }


    }
}
