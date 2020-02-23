using System;
using System.Linq;
using System.Threading.Tasks;

namespace Mijalski.EntityFrameworkCore.IGenerics
{
    public interface IRepository<TEntity> 
    {
        TEntity Get(string name);
        Task<TEntity> GetAsync(string name);
        IQueryable<TEntity> GetAll();
        TEntity Create(TEntity entity);
        Task<TEntity> CreateAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        TEntity Update(TEntity entity);
        void Delete(TEntity entity);
        void Delete(string name);
        Task DeleteAsync(TEntity entity);
        Task DeleteAsync(string name);

    }
}