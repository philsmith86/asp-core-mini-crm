using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspMiniCrm.Models;
using AspMiniCrm.Services;
using AspMiniCrm.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspMiniCrm.Controllers
{
    [Authorize]
    public class EmployeesController : Controller
    {
        private IEmployeeService _employeeService;
        private ICompanyService _companyService;
        
        public EmployeesController(IEmployeeService employeeService, ICompanyService companyService)
        {
            _employeeService = employeeService;
            _companyService = companyService;
        }

        public IActionResult Index()
        {
            var evm = new EmployeeViewModel()
            {
                Employees = _employeeService.GetAllEmployees()
            };

            return View(evm);
        }

        public IActionResult CreateEmployee()
        {
            ViewBag.Companies = _companyService.GetAllCompanies();
            return View();
        }

        [HttpPost]
        public IActionResult CreateEmployee(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Companies = _companyService.GetAllCompanies();
                return View("CreateEmployee");
            }
            _employeeService.AddEmployee(employee);
            return RedirectToAction("Index");
        }

        public IActionResult EditEmployee(int employeeId)
        {
            ViewBag.Companies = _companyService.GetAllCompanies();
            return View(_employeeService.GetEmployeeById(employeeId));
        }

        [HttpPost]
        public IActionResult EditEmployee(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Companies = _companyService.GetAllCompanies();
                return View("EditEmployee", employee);
            }
            _employeeService.UpdateEmployee(employee);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteEmployee(int employeeId)
        {
            _employeeService.DeleteEmployee(employeeId);
            return RedirectToAction("Index");
        }
    }
}