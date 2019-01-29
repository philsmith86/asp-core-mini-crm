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

        public List<Company> GetAllCompanies()
        {
            return _context.Companies.ToList();
        }

        public void AddCompany(Company company)
        {
            _context.Companies.Add(company);
            _context.SaveChanges();
        }

        public Company GetCompanyById(int id)
        {
            return _context.Companies.Single(c => c.Id == id);
        }

        public void UpdateCompany(Company company)
        {
            Company currentCompany = GetCompanyById(company.Id);
            currentCompany.Name = company.Name;
            currentCompany.Email = company.Email;
            currentCompany.Web = company.Web;
            _context.SaveChanges();
            
        }

        public void DeleteCompany(int id)
        {
            Company companyToBeDeleted = GetCompanyById(id);
            _context.Companies.Remove(companyToBeDeleted);
            _context.SaveChanges();
        }
    }
}
