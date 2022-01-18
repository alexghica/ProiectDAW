using Microsoft.EntityFrameworkCore;
using ProiectDAW.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDAW.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {

        protected readonly FacultateContext _context;
        protected readonly DbSet<T> _table;

        public GenericRepository(FacultateContext context)
        {
            _context = context;
            _table = context.Set<T>();
        }

        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _table.Remove(entity);
        }

        public List<T> FindAll()
        {
            return _table.ToList();
        }


        public bool SaveChanges()
        {
            return (_context.SaveChanges() > 0);
        }

        public void Update(T entity)
        {
            _table.Update(entity);
        }

        public T FindById(object id)
        {
            var result = _table.Find(id);
            _context.Entry(result).State = EntityState.Detached;
            return result;
        }
    }
}
