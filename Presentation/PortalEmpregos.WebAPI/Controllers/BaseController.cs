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
    public class BaseController : ControllerBase
    {
        protected IDatabase _cache = null;
        protected PortalEmpregosDbContext _context = null;

        public BaseController(PortalEmpregosDbContext context, IDatabase cache)
        {
            _context = context;
            _cache = cache;
        }
    }
}
