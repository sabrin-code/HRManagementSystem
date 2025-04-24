using HrManagementSystem.Persistence.Context;
using HrManagementSystem.Persistence.Interfaces.Base;
using HrManagementSystem.Persistence.Repositories;
using HrManagemntSystem.Application.Interfaces.Repositories.BaseRepository;
using HrManagemntSystem.Application.Interfaces.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagementSystem.Persistence.UnitOfWork
{
    public class UnitOfWorks : IUnitOfWork
    {
        private readonly HRDbContext _hRContext;
      
        public UnitOfWorks(HRDbContext hRContext)
        {
            _hRContext = hRContext;
        }
        public int Commit()
        {
            return _hRContext.SaveChanges();
        }

        public async Task<int> CommitAsync()
        {
            return await _hRContext.SaveChangesAsync();
        }

        public ICRUDRepository<T>CRUDRepository<T>() where T : class,IBaseEntity
        {
            ICRUDRepository<T> repo = new CRUDRepository<T>(_hRContext);
            return repo;
        }
    }
}
