using System;
using PortalEmpregos.Domain.Interfaces.Repositories

namespace PortalEmpregos.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ICompanyRepository Company { get; }
        int Complete();
    }
}
