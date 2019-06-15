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
        public IEnumerable<CompanyDTO> GetAll()
        {
            using (var unitOfWork = new UnitOfWork(_context, _cache))
            {
                var companies = unitOfWork.Companies.GetAll();
                var companiesDTO = _mapper.Map<List<CompanyDTO>>(companies);

                return companiesDTO;
            }
        }

        public CompanyDTO Get(Guid id)
        {
            using (var unitOfWork = new UnitOfWork(_context, _cache))
            {
                var company = unitOfWork.Companies.Get(id);
                var companyDTO = _mapper.Map<CompanyDTO>(company);

                return companyDTO;
            }
        }

        public CompanyDTO Add(CompanyDTO companyDTO)
        {
            using (var unitOfWork = new UnitOfWork(_context, _cache))
            {
                var company = new Company(Guid.NewGuid(), companyDTO.Name);
                var companyDTOout = _mapper.Map<CompanyDTO>(company);
                
                unitOfWork.Companies.Add(company);
                unitOfWork.Complete();

                return companyDTOout;
            }
        }
    }
}
