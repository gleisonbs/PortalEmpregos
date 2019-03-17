using System;

namespace PortalEmpregos.Domain
{
    public interface ICompany
    {
        Guid Id { get; }
        string Name { get; }
    }
}
