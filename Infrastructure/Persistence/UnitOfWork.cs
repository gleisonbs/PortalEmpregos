using StackExchange.Redis;
using PortalEmpregos.Domain.Interfaces;
using PortalEmpregos.Domain.Interfaces.Repositories;
using PortalEmpregos.Infrastructure.Persistence.Repositories;

namespace PortalEmpregos.Infrastructure.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PortalEmpregosDbContext _context;
        private readonly IDatabase _cache;

        public ICompanyRepository Companies { get; private set; }
        public IJobOpeningRepository JobOpenings { get; private set; }

        public UnitOfWork(PortalEmpregosDbContext context, IDatabase cache)
        {
            _context = context;
            _cache = cache;
            Companies = new CompanyRepository(_context, _cache);
            JobOpenings = new JobOpeningRepository(_context, _cache);
        }

        public int Complete()
        {
            if (_context != null)
                return _context.SaveChanges();
            return 0;
        }

        public void Dispose()
        {
            if (_context != null)
                _context.Dispose();
        }
    }

}
