using Microsoft.EntityFrameworkCore;
using PortalEmpregos.Domain.Model;

namespace PortalEmpregos.Persistence
{
    public class PortalEmpregosDbContext : DbContext
    {
        public PortalEmpregosDbContext(DbContextOptions<PortalEmpregosDbContext> options) : base(options) { }

        public DbSet<Company> Company { get; set; }
    }
}

