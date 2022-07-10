using HrManagementSystem.Domain.Entities.Common;
using HrManagementSystem.Persistence.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HrManagemntSystem.Application.Repositories
{
    public interface ICRUDRepository<T> : IRepository<T> where T : class, IBaseEntity 
    {
        Task<bool> CreateAsync(T entity);
        Task<bool> AddRangeAsync(List<T> entity);
        Task<int> SaveAsync();

        Task<bool> UpdateAsync(T entity);  
        Task<bool> DeleteById(int id);
        bool Delete(T entity);
        bool RemoveRange(List<T>entities);
        IQueryable<T> GetAll();
        IQueryable<T> Find(Expression<Func<T, bool>> filter);
        Task<T> FindByIdAsync(int id);

    }
    
}
