using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MecSampleProject.Models
{
    public class Employee
    {
        [DataNames("Employee_ID", "EmployeeID")]
        public int EmployeeId { get; set; }
        [DataNames("FirstName")]
        public string FirstName { get; set; }
        [DataNames("LastName")]
        public string LastName { get; set; }
        [DataNames("Address")]
        public string Address { get; set; }
        [DataNames("City")]
        public string City { get; set; }
        [DataNames("State")]
        public string State { get; set; }
        [DataNames("Phone")]
        public string Phone { get; set; }

    }
}
