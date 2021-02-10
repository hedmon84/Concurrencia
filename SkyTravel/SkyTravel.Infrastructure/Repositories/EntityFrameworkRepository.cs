using Microsoft.EntityFrameworkCore;
using SkyTravel.Core.Entities;
using SkyTravel.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SkyTravel.Infrastructure.Repositories
{
    public class EntityFrameworkRepository<T> : IRepository<T> where T : BaseEntity
    {
        private SkyTravelDbContext _skyDbContext;
        public EntityFrameworkRepository(SkyTravelDbContext skyDbContext)
        {
            _skyDbContext = skyDbContext;
        }

        public T Add(T entity)
        {
            _skyDbContext.Add(entity);
            _skyDbContext.SaveChanges();
            return entity;
        }

        public IEnumerable<T> Filter(Expression<Func<T, bool>> predicate)
        {
            return _skyDbContext.Set<T>().Where(predicate).ToList();
        }

        public IEnumerable<T> GetAll()
        {
            return _skyDbContext.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _skyDbContext.Set<T>().FirstOrDefault(x => x.Id == id);
        }

        public int SaveChanges()
        {
            return _skyDbContext.SaveChanges();
        }

        public T Update(T entity)
        {
            T updated = _skyDbContext.Update(entity).Entity;
            _skyDbContext.SaveChanges();
            return updated;
        }
    }
}
