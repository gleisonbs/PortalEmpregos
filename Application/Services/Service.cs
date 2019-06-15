using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PortalEmpregos.Infrastructure.Persistence;
using PortalEmpregos.Domain.Entities;
using StackExchange.Redis;
using AutoMapper;

namespace PortalEmpregos.Application.Services
{
    public class Service
    {
        protected IDatabase _cache = null;
        protected PortalEmpregosDbContext _context = null;
        protected IMapper _mapper;

        public Service()
        {
            _context = new PortalEmpregosDbContext();
            _cache = RedisSingleton.Instance;

            _mapper = MapperSingleton.Instance;
        }
    }
}
