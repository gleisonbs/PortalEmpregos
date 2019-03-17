using System;

namespace PortalEmpregos.Domain
{
    public class Company : ICompany
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
