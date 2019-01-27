using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspMiniCrm.Models
{
    public class DbInitialiser
    {
        public static void Seed(CrmDbContext context)
        {
            if (!context.Companies.Any())
            {
                context.AddRange
                (
                    new Company
                    {
                        Name = "Google",
                        Email = "google@email.com",
                        Web = "https://www.google.com",
                    },
                    new Company
                    {
                        Name = "Yahoo",
                        Email = "yahoo@email.com",
                        Web = "https://www.yahoo.com",
                    },
                     new Company
                     {
                         Name = "Microsoft",
                         Email = "microsoft@email.com",
                         Web = "https://www.microsoft.com",
                     },
                     new Company
                     {
                         Name = "Facebook",
                         Email = "facebook@email.com",
                         Web = "https://www.facebook.com",
                     },
                     new Company
                     {
                         Name = "SpaceX",
                         Email = "spacex@email.com",
                         Web = "https://www.space-x.com",
                     });
            }

            context.SaveChanges();

            if (!context.Employees.Any())
            {
                context.AddRange(
                    new Employee
                    {
                        FirstName = "John",
                        LastName = "Adams",
                        Telephone = "01236875212",
                        Email = "john.adams@email.com",
                        CompanyId = 1
                    },
                    new Employee
                    {
                        FirstName = "Peter",
                        LastName = "Jinks",
                        Telephone = "01238675212",
                        Email = "pete.jinks@email.com",
                        CompanyId = 2
                    },
                    new Employee
                    {
                        FirstName = "Lindsey",
                        LastName = "Smith",
                        Telephone = "01654875212",
                        Email = "lindseys@email.com",
                        CompanyId = 3
                    },
                    new Employee
                    {
                        FirstName = "Sarah",
                        LastName = "Kineton",
                        Telephone = "01565875230",
                        Email = "sarahk@email.com",
                        CompanyId = 4
                    },
                    new Employee
                    {
                        FirstName = "Lisa",
                        LastName = "James",
                        Telephone = "01897875212",
                        Email = "thebiglj@email.com",
                        CompanyId = 5
                    }
                );
            }
            
            context.SaveChanges();
        }
    }
}
