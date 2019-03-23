using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortalEmpregos.Domain;
using PortalEmpregos.Persistence;
using PortalEmpregos.Persistence.Repository.Company;

namespace PortalEmpregos.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly CompanyRepository context;
        public CompanyController()
        {
            context = new CompanyRepository();
        }
        // GET api/values

        [HttpGet]
        public IEnumerable<ICompany> Get()
        {
            return context.List();
            //Company company1 = new Company(Guid.NewGuid(), "Company 1");
            //Company company2 = new Company(Guid.NewGuid(), "Company 2");
            //Company company3 = new Company(Guid.NewGuid(), "Company 3");
            //_context.Company.Add(company1);
            //_context.Company.Add(company2);
            //_context.Company.Add(company3);
            //_context.SaveChangesAsync();
            //return new List<ICompany>() {company1, company2, company3};
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ICompany Get(int id)
        {
            ICompany company = new Company(Guid.NewGuid(), "Company teste");
            Console.WriteLine($"{company.Id} -> {company.Name}");
            return company;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
