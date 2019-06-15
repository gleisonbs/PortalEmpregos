using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PortalEmpregos.Domain.Entities;
using PortalEmpregos.Application.Services;
using AutoMapper;

namespace PortalEmpregos.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : BaseController
    {
        protected CompanyService _companyService;
        public CompanyController(CompanyService companyService) => _companyService = companyService;

        [HttpGet]
        public ActionResult Get()
        {
            var companies = _companyService.GetAll();
            var companiesDTO = _mapper.Map<List<CompanyDTO>>(companies);

            return Ok(companiesDTO);
        }

        [HttpGet("{id}")]
        public ActionResult Get(Guid id)
        {
            var company = _companyService.Get(id);
            var companyDTO = _mapper.Map<CompanyDTO>(company);

            return Ok(companyDTO);
        }

        [HttpPost("add")]
        public ActionResult Add(CompanyDTO companyDTO) 
        {
            var company = _companyService.Add(companyDTO);

            return Created($"api/Company/{company.Id.ToString()}", companyDTO);
        }
    }
}
