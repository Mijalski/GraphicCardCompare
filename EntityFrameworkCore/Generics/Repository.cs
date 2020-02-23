using System;
using System.Linq;
using System.Threading.Tasks;
using DomainLogic.Generics;
using DomainLogic.IGenerics;
using Microsoft.EntityFrameworkCore;
using Mijalski.EntityFrameworkCore.IGenerics;

namespace Mijalski.EntityFrameworkCore.Generics
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
    {
        private readonly DatabaseContext _dbContext;

        public Repository(DatabaseContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public TEntity Get(string name)
        {
            return _dbContext.Set<TEntity>()
                .AsNoTracking()
                .FirstOrDefault(e => e.Name == name);
        }

        public async Task<TEntity> GetAsync(string name)
        {
            return await _dbContext.Set<TEntity>()
                .AsNoTracking()
                .FirstOrDefaultAsync(e => e.Name == name);
        }

        public IQueryable<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>()
                .AsNoTracking();
        }

        public TEntity Create(TEntity entity)
        {
            _dbContext.Set<TEntity>()
                .Add(entity);
            _dbContext.SaveChanges();

            return entity;
        }

        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            await _dbContext.Set<TEntity>()
                .AddAsync(entity);
            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            _dbContext.Set<TEntity>()
                .Update(entity);
            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public TEntity Update(TEntity entity)
        {
            _dbContext.Set<TEntity>()
                .Update(entity);
            _dbContext.SaveChanges();

            return entity;
        }

        public void Delete(TEntity entity)
        {
            _dbContext.Set<TEntity>()
                .Remove(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(string name)
        {
            var entityToDelete = Get(name);
            Delete(entityToDelete);
        }

        public async Task DeleteAsync(TEntity entity)
        {
            _dbContext.Set<TEntity>()
                .Remove(entity);
            await _dbContext.SaveChangesAsync();

        }

        public async Task DeleteAsync(string name)
        {
            var entityToDelete = await GetAsync(name);
            await DeleteAsync(entityToDelete);
        }
    }
}