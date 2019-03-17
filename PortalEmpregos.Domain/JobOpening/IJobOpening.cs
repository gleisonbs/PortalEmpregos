using System;

namespace PortalEmpregos.Domain
{
    public interface IJobOpening
    {
        Guid Id { get; }
        string Name { get; }
    }
}
