using System;

namespace PortalEmpregos.Domain
{
    public class Applicant
    {
		private Applicant() { /* for EF Core */ }

		public Applicant(Guid id, string name)
		{
			Id = id;
			Name = name;
		}

        public Guid Id { get; private set; }
        public string Name { get; private set; }
    }
}
