using System;

namespace PortalEmpregos.Domain
{
    public interface ICurriculum
    {
        Guid Id { get; }
        string Name { get; }
    }
}
