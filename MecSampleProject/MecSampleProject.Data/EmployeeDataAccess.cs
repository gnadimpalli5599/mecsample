using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MecSampleProject.Models;
using System.Data;
using System.Data.SqlClient;


namespace MecSampleProject.Data
{
    public class EmployeeDataAccess:IEmployeeDataAccess
    {

        #region Standard
        //public List<Employee> GetEmployeeList()
        //{
        //    List<Employee> listEmployees = null;


        //    using (DataTable table = SqlHelper.ExecuteSelectCommand("GetEmployeeList", CommandType.StoredProcedure))
        //    {
        //        if (table.Rows.Count > 0)
        //        {
        //            listEmployees = new List<Employee>();
        //            foreach (DataRow row in table.Rows)
        //            {
        //                Employee emp = new Employee();
        //                emp.EmployeeId = Convert.ToInt32(row["EmployeeID"]);
        //                emp.FirstName = row["FirstName"].ToString();
        //                emp.LastName = row["LastName"].ToString();
        //                emp.Address = row["Address"].ToString();
        //                emp.City = row["City"].ToString();
        //                emp.State = row["State"].ToString();
        //                emp.Phone = row["Phone"].ToString();

        //                listEmployees.Add(emp);
        //            }
        //        }
        //    }
        //    return listEmployees;

        //}

        #endregion Standard


        public List<Employee> GetEmployeeList()
        {
            List<Employee> listEmployees = null;

            DataNamesMapper<Employee> mapper = new DataNamesMapper<Employee>();
            DataTable table = SqlHelper.ExecuteSelectCommand("GetEmployeeList", CommandType.StoredProcedure, null);
            listEmployees = mapper.Map(table).ToList();
            return listEmployees;
        }

        public Employee GetEmployee(int empId)
        {
            Employee emp = null;

            DataNamesMapper<Employee> mapper = new DataNamesMapper<Employee>();
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter empIdParameter = new SqlParameter("@EmployeeID", empId);
            parameters.Add(empIdParameter);
            DataTable table = SqlHelper.ExecuteSelectCommand("GetEmployee", CommandType.StoredProcedure, parameters.ToList());
            emp = mapper.Map(table).ToList().FirstOrDefault();
            return emp;
        }

    }
}
