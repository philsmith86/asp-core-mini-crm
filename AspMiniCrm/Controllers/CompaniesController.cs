using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspMiniCrm.Models;
using AspMiniCrm.Services;
using AspMiniCrm.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AspMiniCrm.Controllers
{
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

        public IActionResult AddCompany([Bind] Company company)
        {
            //if (ModelState.IsValid)
            //{
            //    if (company.AddGroupMeeting(groupMeeting) > 0)
            //    {
            //        return RedirectToAction("Index");
            //    }
            //}
            return RedirectToAction("Index");
        }
    }
}