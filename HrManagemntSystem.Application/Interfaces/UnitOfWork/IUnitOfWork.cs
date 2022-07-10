using HrManagementSystem.Persistence.Interfaces.Base;
using HrManagemntSystem.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagemntSystem.Application.Interfaces.UnitOfWork
{
    public interface IUnitOfWork
    {
        ICRUDRepository<T> CRUDRepository<T>() where T : class, IBaseEntity;
        int Commit();
        Task<int> CommitAsync();
    }
}
