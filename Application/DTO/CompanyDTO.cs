using System;

namespace PortalEmpregos.Application.Services
{
    public class CompanyDTO
    {
		public CompanyDTO(Guid id, string name)
		{
            Id = id;
			Name = name;
		}

        public Guid Id { get; private set; }
        public string Name { get; private set; }
    }
}
