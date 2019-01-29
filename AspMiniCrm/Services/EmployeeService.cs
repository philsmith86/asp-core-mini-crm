using AspMiniCrm.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspMiniCrm.Services
{
    public class EmployeeService : IEmployeeService
    {
        private CrmDbContext _context;
        public EmployeeService(CrmDbContext context)
        {
            _context = context;
        }

        public List<Employee> GetAllEmployees()
        {
            return _context.Employees.Include(e => e.Company).ToList();
        }

        public void AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public Employee GetEmployeeById(int id)
        {
            return _context.Employees.Single(c => c.Id == id);
        }

        public void UpdateEmployee(Employee employee)
        {
            Employee currentEmployee = GetEmployeeById(employee.Id);
            currentEmployee.FirstName = employee.FirstName;
            currentEmployee.LastName = employee.LastName;
            currentEmployee.Telephone = employee.Telephone;
            currentEmployee.Email = employee.Email;
            currentEmployee.CompanyId = employee.CompanyId;
            _context.SaveChanges();

        }

        public void DeleteEmployee(int id)
        {
            Employee employeeToBeDeleted = GetEmployeeById(id);
            _context.Employees.Remove(employeeToBeDeleted);
            _context.SaveChanges();
        }
    }
}
