using System;
using System.Collections.Generic;
using System.Linq;
using StackExchange.Redis;
using PortalEmpregos.Domain.Entities;
using PortalEmpregos.Domain.Interfaces.Repositories;
using PortalEmpregos.Infrastructure.Persistence;

namespace PortalEmpregos.Infrastructure.Persistence.Repositories
{
    public class JobOpeningRepository : Repository<JobOpening>, IJobOpeningRepository
    {
        public JobOpeningRepository(PortalEmpregosDbContext context, IDatabase cache) : base(context, cache) {}
    }
}
