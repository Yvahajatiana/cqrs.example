using EmployementManagementLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployementManagementLib.Data
{
    public interface IDataAccess
    {
        List<EmployeeModel> GetEmployees();

        EmployeeModel AddEmployee(string firstName, string lastName);
    }
}
