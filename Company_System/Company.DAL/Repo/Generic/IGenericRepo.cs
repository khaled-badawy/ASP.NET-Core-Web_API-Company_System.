using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.DAL
{
    public interface IGenericRepo<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity? GetByID(int id);
        void Add(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
        int SaveChanges();

    }
}
