using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortalEmpregos.Infrastructure.Persistence;
using PortalEmpregos.Domain.Entities;
using StackExchange.Redis;

namespace PortalEmpregos.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : BaseController
    {
        public CompanyController(PortalEmpregosDbContext context, IDatabase cache) : base(context, cache) {}

        [HttpGet]
        public IEnumerable<Company> Get()
        {
            using (var unitOfWork = new UnitOfWork(_context, _cache))
            {
                var companies = unitOfWork.Companies.GetAll();
                return companies;
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Company Get(Guid id)
        {
            using (var unitOfWork = new UnitOfWork(_context, _cache))
            {
                Company company = unitOfWork.Companies.Get(id);
                return company;
            }
        }
    }
}
