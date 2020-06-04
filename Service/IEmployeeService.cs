using CoreWebAPI.Context.Sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebAPI.Service
{
    public interface IEmployeeService
    {
        List<Employee> GetAllEmployees();
    }
}
