using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspMiniCrm.Models;

namespace AspMiniCrm.Services
{
    public class CompanyService : ICompanyService
    {
        private CrmDbContext _context;
        public CompanyService(CrmDbContext context)
        {
            _context = context;
        }

        public void AddCompany()
        {
            throw new NotImplementedException();
        }

        public List<Company> GetAllCompanies()
        {
            return _context.Companies.ToList();
        }
    }
}
