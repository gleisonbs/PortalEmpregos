using System;

namespace PortalEmpregos.Domain
{
    public class Curriculum
    {
		private Curriculum() { /* for EF Core */ }

		public Curriculum(Guid id, string name)
		{
			Id = id;
			Name = name;
		}

        public Guid Id { get; private set; }
        public string Name { get; private set; }
    }
}

