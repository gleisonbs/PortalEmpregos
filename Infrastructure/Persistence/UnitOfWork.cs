using PortalEmpregos.Domain.Interfaces;

namespace PortalEmpregos.Infrastructure.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PortalEmpregosDbContext _context;
        public ICompanyRepository Companies { get; private set; }

        public UnitOfWork(PortalEmpregosDbContext context)
        {
            _context = context;
            Company = new CompanyRepository(_context);
        }

        public int Complete() => _context.SaveChanges();

        public void Dispose() => _context.Dispose();
    }

}
