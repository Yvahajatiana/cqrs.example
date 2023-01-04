using EmployementManagementLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployementManagementLib.Data
{
    public class DataAccess : IDataAccess
    {
        private List<EmployeeModel> employeeModels = new();

        public DataAccess() 
        {
            employeeModels.Add(new EmployeeModel { Id = 1, FirstName = "First Guys", LastName = "Last Guys"});
            employeeModels.Add(new EmployeeModel { Id = 2, FirstName = "First Girls", LastName = "Last Girls"});
        }

        public EmployeeModel AddEmployee(string firstName, string lastName)
        {
            EmployeeModel newEmployee = new() { FirstName= firstName, LastName = lastName };
            newEmployee.Id = employeeModels.Max(x => x.Id) + 1;

            return newEmployee;
        }

        public List<EmployeeModel> GetEmployees()
        {
            return employeeModels;
        }
    }
}
