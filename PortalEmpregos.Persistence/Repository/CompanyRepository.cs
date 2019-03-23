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
            context = DbHelper.Context;
        }

        public IEnumerable<ICompany> List()
        {
            return context.Company.ToList();
        }
    }
}
