using PortalEmpregos.Infrastructure.Persistence;
using Autofac;

namespace IOC
{
    public static class IOCContainer
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<PortalEmpregosDbContext>().As<PortalEmpregosDbContext>();

            return builder.Build();
        }
    }
}
