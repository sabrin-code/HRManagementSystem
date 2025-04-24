using HrManagementSystem.Domain.Entities.Common;
using HrManagementSystem.Persistence.Interfaces.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagemntSystem.Application.Interfaces.Repositories.BaseRepository
{
    public interface IRepository<T> where T : class,IBaseEntity 
    {
        DbSet<T> Table { get; }
    }
   
}
