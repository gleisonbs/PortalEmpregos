
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using PortalEmpregos.Domain;
using PortalEmpregos.Persistence;
using System.IO;

namespace PortalEmpregos.Persistence
{
    public class DbHelper
    {
        public static readonly string ConnectionStringName = "PortalEmpregosConnectionString";
        public static readonly string AspNetCoreEnvironment = "ASPNETCORE_ENVIRONMENT";

        private DbHelper() {}

        private static string connectionString = null;
        public static string ConnectionString
        {
            get
            {
                if (connectionString is null)
                {
                    var environmentName = Environment.GetEnvironmentVariable(AspNetCoreEnvironment);
                    var basePath = Directory.GetCurrentDirectory();
                    basePath = basePath.Substring(0, basePath.LastIndexOf("/"));
                    basePath = Path.Join(basePath, "PortalEmpregos.Persistence");

                    var configuration = new ConfigurationBuilder()
                        .SetBasePath(basePath)
                        .AddJsonFile("appsettings.json")
                        .AddJsonFile($"appsettings.Local.json", optional: true)
                        .AddJsonFile($"appsettings.{environmentName}.json", optional: true)
                        .AddEnvironmentVariables()
                        .Build();

                    connectionString = configuration.GetConnectionString(ConnectionStringName);
                }

                return connectionString;
            }
        }

        private static PortalEmpregosDbContext context = null;
        public static PortalEmpregosDbContext Context
        {
            get
            {
                if (context is null)
                {
                    var optionsBuilder = new DbContextOptionsBuilder<PortalEmpregosDbContext>();
                    optionsBuilder.UseNpgsql(ConnectionString);
                    context = new PortalEmpregosDbContext(optionsBuilder.Options);
                }

                return context;
            }
        }
    }
}
