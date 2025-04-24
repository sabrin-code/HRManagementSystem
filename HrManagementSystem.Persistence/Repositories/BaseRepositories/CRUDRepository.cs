using HrManagementSystem.Domain.Entities.Common;
using HrManagementSystem.Persistence.Context;
using HrManagementSystem.Persistence.Interfaces.Base;
using HrManagemntSystem.Application.Interfaces.Repositories.BaseRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HrManagementSystem.Persistence.Repositories
{
    public class CRUDRepository<T> : ICRUDRepository<T> where T : class, IBaseEntity
    {
        private readonly HRDbContext _context;
        public CRUDRepository(HRDbContext context)
        {
            _context = context;
        }
        public DbSet<T> Table => _context.Set<T>();

        public async Task<bool> AddRangeAsync(List<T> entity)
        {
            await Table.AddRangeAsync(entity);
            return true;
        }

        public async Task<bool> CreateAsync(T entity)
        {
            EntityEntry<T>entityEntry=await Table.AddAsync(entity);
            return entityEntry.State==EntityState.Added;
        }

        public bool Delete(T entity)
        {
            EntityEntry<T> entityEntry =  Table.Remove(entity);
            return entityEntry.State==EntityState.Deleted;
        }

        public async Task<bool> DeleteById(int id)
        {
            T entity=await Table.FirstOrDefaultAsync(x => x.Id==id);
            return Delete(entity);
        }

        public bool RemoveRange(List<T> entities)
        {
            Table.RemoveRange(entities);
            return true;
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdateAsync(T entity)
        {
            EntityEntry<T> entityEntry = Table.Update(entity);
            return entityEntry.State==EntityState.Modified;
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> filter) => Table.Where(filter);

        public async Task<T> FindByIdAsync(int id) => await Table.FindAsync(id);

        public IQueryable<T> GetAll() => Table;

        
    }
}
