using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspMiniCrm.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspMiniCrm.Controllers
{
    public class CompaniesController : Controller
    {

        private CrmDbContext dbContext;

        public CompaniesController(CrmDbContext context)
        {
            dbContext = context;
        }

        public IActionResult Index()
        {
            return View(dbContext.Companies.ToList());
        }
    }
}