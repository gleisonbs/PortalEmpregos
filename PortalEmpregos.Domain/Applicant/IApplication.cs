using System;

namespace PortalEmpregos.Domain
{
    public interface IApplication
    {
        Guid Id { get; }
        string Name { get; }
    }
}
