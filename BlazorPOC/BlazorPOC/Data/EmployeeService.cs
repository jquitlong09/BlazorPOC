using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace BlazorPOC.Data
{
   
    public class EmployeeService : IEmployeeService
    {
        private List<Employee> employees = new List<Employee>
        {
            new Employee
            {
                Id = Guid.NewGuid(),
                Name = "Employee1",
                CountryCode = "63",
                Number = "9474418518",
                EmailAddress = "test@yopmail.com"
            },
            new Employee
            {
                Id = Guid.NewGuid(),
                Name = "Employee2",
                CountryCode = "63",
                Number = "9269581022",
                EmailAddress = "joanna@yopmail.com"
            }
        };

        public void AddEmployee(Employee employee)
        {
            var id = Guid.NewGuid();
            employee.Id = id;
            employees.Add(employee);
        }

        public void DeleteEmployee(Guid id)
        {
            var employee = GetEmployee(id);
            employees.Remove(employee);
        }

        public Employee GetEmployee(Guid id)
        {
            return employees.SingleOrDefault(x => x.Id == id);
        }


        public List<Employee> GetEmployees()
        {
            return employees;
        }

        public void UpdateEmployee(Employee employee)
        {
            var getOldEmployee = GetEmployee(employee.Id);
            getOldEmployee.Name = employee.Name;
        }
    }
}
