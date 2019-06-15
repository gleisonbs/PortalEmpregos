using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore.Design;
using PortalEmpregos.Domain.Entities;
using StackExchange.Redis;

namespace PortalEmpregos.Infrastructure.Persistence
{
    public class RedisSingleton
    {
        private RedisSingleton() {}

        private static readonly IDatabase _instance = ConnectionMultiplexer.Connect("localhost").GetDatabase();
        public static IDatabase Instance 
        {
            get 
            {
                return _instance;
            }
        }
    }
}

