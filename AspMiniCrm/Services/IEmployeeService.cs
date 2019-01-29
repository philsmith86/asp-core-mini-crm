using AspMiniCrm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspMiniCrm.Services
{
    public interface IEmployeeService
    {
        List<Employee> GetAllEmployees();
        void AddEmployee(Employee employee);
        Employee GetEmployeeById(int id);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(int id);
    }
}
