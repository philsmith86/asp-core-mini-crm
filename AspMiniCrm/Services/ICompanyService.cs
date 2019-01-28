using AspMiniCrm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspMiniCrm.Services
{
    public interface ICompanyService
    {
        List<Company> GetAllCompanies();
        void AddCompany();
    }
}
