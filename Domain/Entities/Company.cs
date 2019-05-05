using System;

namespace PortalEmpregos.Domain.Entities
{
    public class Company
    {
		private Company() { /* for EF Core */ }

		public Company(Guid id, string name)
		{
			Id = id;
			Name = name;
		}

        public Guid Id { get; private set; }
        public string Name { get; private set; }
    }
}
