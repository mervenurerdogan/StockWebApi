using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Core.Repositories
{
   public interface IRepository<TEntity> where TEntity:class
    {

        Task<TEntity> GetByIdAsync(int id);//Id ile listeleme
        Task<IEnumerable<TEntity>> GetAllAsync();//Tüm hepsini listeleme
        Task<IEnumerable<TEntity>> Where(Expression<Func<TEntity, bool>> predicate);//find ile herhangi bir parametreye göre nesne bulup getirecek

        Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);

        Task AddAsyn(TEntity entity);//Ekleme

        Task AddRangeAsync(IEnumerable<TEntity> entities);//birden fazla kayıt için

        void Remove(TEntity entity);

        void RemoveRange(IEnumerable<TEntity> entities);//birden fazla silme

        TEntity Update(TEntity entity);


    }
}
