using EmployementManagementLib.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployementManagementLib.Queries
{
    public record GetEmployeeListQuery() : IRequest<List<EmployeeModel>>;
}
