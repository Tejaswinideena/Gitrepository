using BusinessLogicLibrary;
using DataAccessLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperLibrary
{
    public class Employee_Helper
    {
        Employee_DAL dal = null;
        public Employee_Helper()
        {
            dal = new Employee_DAL();
        }


        public bool AddEmployee(Employee_BAL employee)
        {
            return dal.InsertEmployee(employee);

        }
        public bool AddEmployees(Employee_BAL employee)
        {
            return dal.InsertEmployees(employee);

        }
        public bool EditEmployee(Employee_BAL employee)
        {
            return dal.UpdateEmployee(employee);
        }

    }
}
