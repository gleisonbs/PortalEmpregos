using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore.Design;
using PortalEmpregos.Domain.Entities;

namespace PortalEmpregos.Infrastructure.Persistence
{
    public class PortalEmpregosDbContext : DbContext
    {
        public static readonly string ConnectionStringName = "PortalEmpregosConnectionString";
        public static readonly string AspNetCoreEnvironment = "ASPNETCORE_ENVIRONMENT";

        public PortalEmpregosDbContext() : base() { }

        public DbSet<Company> Company { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var environmentName = Environment.GetEnvironmentVariable(AspNetCoreEnvironment);
            Console.WriteLine(environmentName);
            var basePath = Directory.GetCurrentDirectory();
            Console.WriteLine(basePath);
            basePath = basePath.Substring(0, basePath.LastIndexOf("/"));
            basePath = Path.Join(basePath, "Persistence");
            Console.WriteLine(basePath);

            var configuration = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.json")
                .AddJsonFile($"appsettings.Local.json", optional: true)
                .AddJsonFile($"appsettings.{environmentName}.json", optional: true)
                .AddEnvironmentVariables()
                .Build();

            string connectionString = configuration.GetConnectionString(ConnectionStringName);
            optionsBuilder.UseNpgsql(connectionString);
        }
    }
}

