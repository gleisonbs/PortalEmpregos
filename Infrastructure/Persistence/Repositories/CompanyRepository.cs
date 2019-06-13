using System;
using System.Collections.Generic;
using System.Linq;
using StackExchange.Redis;
using PortalEmpregos.Domain.Entities;
using PortalEmpregos.Domain.Interfaces.Repositories;
using PortalEmpregos.Infrastructure.Persistence;

namespace PortalEmpregos.Infrastructure.Persistence.Repositories
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        public CompanyRepository(PortalEmpregosDbContext context, IDatabase cache) : base(context, cache) {}

        public IEnumerable<Company> GetCompaniesWithMostJobOpenings(int companiesCount)
        {
            return _context.Company.OrderByDescending(c => c.Id).Take(companiesCount).ToList();
        }
    }
}
