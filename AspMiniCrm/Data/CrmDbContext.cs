using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspMiniCrm.Models
{
    public class CrmDbContext : DbContext
    {
        public CrmDbContext(DbContextOptions<CrmDbContext> options) : base(options)
        {

        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
