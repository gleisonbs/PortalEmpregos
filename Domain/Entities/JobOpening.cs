using System;

namespace PortalEmpregos.Domain.Entities
{
    public class JobOpening
    {
		private JobOpening() { /* for EF Core */ }

		public JobOpening(Guid id, Company company, string name)
		{
			Validate(company);

			Id = id;
			CompanyId = company.Id;
			Name = name;
		}

		private void Validate(Company company)
		{
			if (company is null)
				throw new Exception("Company is invalid");
		}

        public Guid Id { get; private set; }
		public Guid CompanyId { get; private set; }
        public string Name { get; private set; }
    }
}
