using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PortalEmpregos.Domain.Entities;
using PortalEmpregos.Application.Services;

namespace PortalEmpregos.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobOpeningController : BaseController
    {
        protected JobOpeningService _jobOpeningService;
        public JobOpeningController(JobOpeningService jobOpeningService) => _jobOpeningService = jobOpeningService;

        [HttpGet]
        public ActionResult Get()
        {
            var jobOpenings = _jobOpeningService.GetAll();

            return Ok(jobOpenings);
        }

        [HttpGet("{id}")]
        public ActionResult Get(Guid id)
        {
            var jobOpening = _jobOpeningService.Get(id);

            return Ok(jobOpening);
        }

        [HttpPost("add")]
        public ActionResult Add(JobOpeningDTO jobOpeningDTO) 
        {
            var jobOpening = _jobOpeningService.Add(jobOpeningDTO);

            if (jobOpening.ErrorMessage != null)
                return BadRequest(jobOpening.ErrorMessage);

            return Created($"api/JobOpening/{jobOpening.Id.ToString()}", jobOpening);
        }
    }
}
