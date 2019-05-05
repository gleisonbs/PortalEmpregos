using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortalEmpregos.Infrastructure.Persistence;
using PortalEmpregos.Domain.Entities;

namespace PortalEmpregos.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Company> Get()
        {
            using (var UnitOfWork = new UnitOfWork(PortalEmpregosDbContext()))
            {
                IEnumerable<Company> companies = unitOfWork.Companies.GetCompaniesWithMostJobOpenings(1);
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Company Get(int id)
        {
        }
    }
}
