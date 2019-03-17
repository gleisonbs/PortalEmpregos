﻿using Microsoft.EntityFrameworkCore;
using PortalEmpregos.Domain;

namespace PortalEmpregos.Persistence
{
    public class PortalEmpregosDbContext : DbContext
    {
        public PortalEmpregosDbContext(DbContextOptions<PortalEmpregosDbContext> options) : base(options) { }

        public DbSet<ICompany> Company { get; set; }
    }
}

