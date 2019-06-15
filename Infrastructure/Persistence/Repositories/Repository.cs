using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using StackExchange.Redis;
using PortalEmpregos.Infrastructure.Persistence;
using PortalEmpregos.Domain.Interfaces.Repositories;
using PortalEmpregos.Domain.Entities;

namespace PortalEmpregos.Infrastructure.Persistence.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected PortalEmpregosDbContext _context;
        protected IDatabase _cache;

        public Repository(PortalEmpregosDbContext context, IDatabase cache)
        {
            _context = context;
            _cache = cache;
        }

        public TEntity Get(Guid id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().Where(predicate);
        }

        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().AddRange(entities);
        }

        public void Remove(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().RemoveRange(entities);
        }
    }
}
