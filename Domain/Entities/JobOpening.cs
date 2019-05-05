using System;

namespace PortalEmpregos.Domain
{
    public class JobOpening : IJobOpening
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
