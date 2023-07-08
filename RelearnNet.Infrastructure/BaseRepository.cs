using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelearnNet.Infrastructure
{
    public abstract class BaseRepository<T> : IDisposable where T : class
    {
        protected readonly DbContext _context;
        protected readonly DbSet<T> _entity;

        public BaseRepository(DbContext context)
        {
            _context = context;
            _entity = context.Set<T>();
        }

        public void Create(T entity)
        {
            _entity.Add(entity);
            Save();
        }
        public virtual IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(Guid id)
        {
            return _entity.Find(id);
        }

        public void Update(T entity)
        {
            _entity.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            Save();
        }

        public void Delete(T entity)
        {
            _entity.Remove(entity);
            Save();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }

}
