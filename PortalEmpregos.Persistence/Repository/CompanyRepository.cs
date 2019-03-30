using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using PortalEmpregos.Domain;
using PortalEmpregos.Persistence;
using System.IO;

namespace PortalEmpregos.Persistence.Repository.Company
{
    public class CompanyRepository
    {
        private PortalEmpregosDbContext context;

        public CompanyRepository()
        {
            context = new PortalEmpregosDbContext();
        }

        public IEnumerable<ICompany> List()
        {
            return context.Company.ToList();
        }

        public void Add(ICompany company)
        {
            context.Add(company);
            context.SaveChanges();
        }
    }
}
