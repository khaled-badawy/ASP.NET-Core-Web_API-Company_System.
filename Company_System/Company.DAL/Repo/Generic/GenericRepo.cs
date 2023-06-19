using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.DAL;

namespace Company.DAL
{
    public class GenericRepo<TEntity> : IGenericRepo<TEntity> where TEntity : class
    {
        private readonly CompanyContext _context;

        public GenericRepo(CompanyContext context)
        {
            _context = context;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>();
        }

        public TEntity? GetByID(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public void Add(TEntity entity)
        {
             _context.Set<TEntity>().Add(entity);
        }

        public void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }
        public void Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
        }
        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

    }
}
