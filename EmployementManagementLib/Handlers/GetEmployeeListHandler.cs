using EmployementManagementLib.Data;
using EmployementManagementLib.Models;
using EmployementManagementLib.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployementManagementLib.Handlers
{
    public class GetEmployeeListHandler : IRequestHandler<GetEmployeeListQuery, List<EmployeeModel>>
    {
        private readonly IDataAccess dataAccess;

        public GetEmployeeListHandler(IDataAccess dataAccess) 
        {
            this.dataAccess = dataAccess;
        }

        public Task<List<EmployeeModel>> Handle(GetEmployeeListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(dataAccess.GetEmployees());
        }
    }
}
