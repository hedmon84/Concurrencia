using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using TravelAgency.Core.Entities;
using TravelAgency.Core.Interface;
using TravelAgency.Infrastructure;

namespace TravelAgency.Infrastructure.Repositories
{
    public class EntityFrameworkRepository<T> : IRepository<T> where T : BaseEntity
    {
        private TravelAgencyDbContext _travelDbContext;
        public EntityFrameworkRepository(TravelAgencyDbContext tunesDbContext)
        {
            _travelDbContext = tunesDbContext;
        }

        public T Add(T entity)
        {
            _travelDbContext.Add(entity);
            _travelDbContext.SaveChanges();
            return entity;
        }

        public IEnumerable<T> Filter(Expression<Func<T, bool>> predicate)
        {
            return _travelDbContext.Set<T>().Where(predicate).ToList();
        }

        public IEnumerable<T> GetAll()
        {
            return _travelDbContext.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _travelDbContext.Set<T>().FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<T> GetSongsByAlbum()
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            return _travelDbContext.SaveChanges();
        }

        public T Update(T entity)
        {
            T updated = _travelDbContext.Update(entity).Entity;
            _travelDbContext.SaveChanges();
            return updated;
        }
    }
}
