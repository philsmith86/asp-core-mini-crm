using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspMiniCrm.Models;
using AspMiniCrm.Services;
using AspMiniCrm.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AspMiniCrm.Controllers
{
    [Authorize]
    public class CompaniesController : Controller
    {
        private ICompanyService _companyService;
        public CompaniesController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        public IActionResult Index()
        {
            var cvm = new CompanyViewModel()
            {
                Companies = _companyService.GetAllCompanies()
            };

            return View(cvm);
        }

        public IActionResult CreateCompany()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCompany(Company company)
        {
            if (!ModelState.IsValid)
            {
                return View("CreateCompany");
            }
            _companyService.AddCompany(company);
            return RedirectToAction("Index");
        }

        public IActionResult EditCompany(int companyId)
        {
            return View(_companyService.GetCompanyById(companyId));
        }

        [HttpPost]
        public IActionResult EditCompany(Company company)
        {
            if (!ModelState.IsValid)
            {
                return View("EditCompany", company);
            }
            _companyService.UpdateCompany(company);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteCompany(int companyId)
        {
            _companyService.DeleteCompany(companyId);
            return RedirectToAction("Index");
        }
    }
}