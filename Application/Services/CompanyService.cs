using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PortalEmpregos.Infrastructure.Persistence;
using PortalEmpregos.Domain.Entities;
using StackExchange.Redis;

namespace PortalEmpregos.Application.Services
{
    public class CompanyService : Service
    {
        public IEnumerable<Company> GetAll()
        {
            using (var unitOfWork = new UnitOfWork(_context, _cache))
            {
                var companies = unitOfWork.Companies.GetAll();
                return companies;
            }
        }

        public Company Get(Guid id)
        {
            using (var unitOfWork = new UnitOfWork(_context, _cache))
            {
                Company company = unitOfWork.Companies.Get(id);
                return company;
            }
        }

        public Company Add(CompanyDTO companyDTO)
        {
            using (var unitOfWork = new UnitOfWork(_context, _cache))
            {
                var company = new Company(Guid.NewGuid(), companyDTO.Name);
                
                unitOfWork.Companies.Add(company);
                unitOfWork.Complete();

                return company;
            }
        }
    }
}
