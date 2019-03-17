using Microsoft.EntityFrameworkCore;

namespace PortalEmpregos.Persistence
{
    public class PortalEmpregosDbContextFactory : DesignTimeDbContextFactoryBase<PortalEmpregosDbContext>
    {
        protected override PortalEmpregosDbContext CreateNewInstance(DbContextOptions<PortalEmpregosDbContext> options)
        {
            return new PortalEmpregosDbContext(options);
        }
    }
}
