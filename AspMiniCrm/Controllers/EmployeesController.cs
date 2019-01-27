using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspMiniCrm.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspMiniCrm.Controllers
{
    public class EmployeesController : Controller
    {
        private CrmDbContext dbContext;

        public EmployeesController(CrmDbContext context)
        {
            dbContext = context;
        }

        public IActionResult Index()
        {
            List<Employee> employees = dbContext.Employees.Include(e => e.Company).ToList();
            return View(employees);
        }
    }
}