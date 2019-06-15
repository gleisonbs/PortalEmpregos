using System;
using System.ComponentModel.DataAnnotations.Schema;
using PortalEmpregos.Domain.Entities;

namespace PortalEmpregos.Application.Services
{
    public class JobOpeningDTO
    {
		public JobOpeningDTO(Guid companyId, Guid id, string name)
		{
            Id = id;
            CompanyId = companyId;
			Name = name;
		}

        public Guid Id { get; private set; }
        public Guid CompanyId { get; private set; }
        public string Name { get; private set; }

        public string ErrorMessage { get; set; } = null;
    }
}
