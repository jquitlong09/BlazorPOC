using System.Collections.Generic;

namespace BlazorPOC.Data
{
    interface IEmployee
    {
        List<Employee> GetEmployees();
    }
}
