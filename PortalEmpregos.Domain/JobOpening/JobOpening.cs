using System;

namespace PortalEmpregos.Domain.Model
{
    public class JobOpening
    {
		private JobOpening() { /* for EF Core */ }

		public JobOpening(Guid id, string name)
		{
			Id = id;
			Name = name;
		}

        public Guid Id { get; private set; }
        public string Name { get; private set; }
    }
}
