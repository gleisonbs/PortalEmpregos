using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PortalEmpregos.Domain.Model;

namespace PortalEmpregos.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Company>> Get()
        {
			List<Company> companies = new List<Company>();
            Company company1 = new Company(Guid.NewGuid(), "Company 1");
            Company company2 = new Company(Guid.NewGuid(), "Company 2");
            Company company3 = new Company(Guid.NewGuid(), "Company 3");
            return new List<Company>() {company1, company2, company3};
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Company> Get(int id)
        {
            Company company = new Company(Guid.NewGuid(), "Company teste");
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
