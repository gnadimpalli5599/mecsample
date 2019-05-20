using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MecSampleProject.Models;
namespace MecSampleProject.Business
{
    public interface IEmployeeBusiness
    {
         List<Employee> GetEmployeeList();
    }
}
