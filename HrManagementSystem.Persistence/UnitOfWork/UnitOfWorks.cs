using HrManagementSystem.Persistence.Context;
using HrManagementSystem.Persistence.Interfaces.Base;
using HrManagementSystem.Persistence.Repositories;
using HrManagemntSystem.Application.Interfaces.UnitOfWork;
using HrManagemntSystem.Application.Repositories;
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
        private readonly Dictionary<Type, object> _repositories = new Dictionary<Type, object>();
        Dictionary<Type, object> Repositories
        {
            get { return _repositories; }
            set { Repositories = value; }
        }
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
