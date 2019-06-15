using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PortalEmpregos.Infrastructure.Persistence;
using PortalEmpregos.Domain.Entities;
using StackExchange.Redis;

namespace PortalEmpregos.Application.Services
{
    public class JobOpeningService : Service
    {
        public IEnumerable<JobOpeningDTO> GetAll()
        {
            using (var unitOfWork = new UnitOfWork(_context, _cache))
            {
                var jobOpenings = unitOfWork.JobOpenings.GetAll();

                var jobOpeningsDTO = _mapper.Map<List<JobOpeningDTO>>(jobOpenings);
                return jobOpeningsDTO;
            }
        }

        public JobOpeningDTO Get(Guid id)
        {
            using (var unitOfWork = new UnitOfWork(_context, _cache))
            {
                var jobOpening = unitOfWork.JobOpenings.Get(id);

                var jobOpeningDTO = _mapper.Map<JobOpeningDTO>(jobOpening);
                return jobOpeningDTO;
            }
        }

        public JobOpeningDTO Add(JobOpeningDTO jobOpeningDTO)
        {
            using (var unitOfWork = new UnitOfWork(_context, _cache))
            {
                try
                {
                    var company = unitOfWork.Companies.Get(jobOpeningDTO.CompanyId);
                    var jobOpening = new JobOpening(Guid.NewGuid(), company, jobOpeningDTO.Name);
                    
                    unitOfWork.JobOpenings.Add(jobOpening);
                    unitOfWork.Complete();

                    jobOpeningDTO = _mapper.Map<JobOpeningDTO>(jobOpening);
                }
                catch (Exception ex)
                {
                    jobOpeningDTO.ErrorMessage = ex.Message;
                }

                return jobOpeningDTO;
            }
        }
    }
}
