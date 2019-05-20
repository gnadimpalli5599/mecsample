using System;
using MecSampleProject.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MecSampleProject.Models;
using MecSampleProject.Data;

namespace MecSampleProject.UnitTests
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void GetAllEmployees_EmployeeExists_ReturnsTrue()
        {
            EmployeeDataAccess ed = new EmployeeDataAccess();
            var employee = new Employee();
            employee.EmployeeId = 5;
            employee.LastName = "Olphant";
            employee.FirstName = "Tqbigir";
            employee.Address = "191-3212 Enim, St.";
            employee.City = "Erie";
            employee.State = "PA";
            employee.Phone = "1-503-256-1715";

            var actual = ed.GetEmployee(5);
            Assert.AreEqual(employee, actual);

        }
    }
}
