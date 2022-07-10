using HrManagementSystem.Domain.Entities.Identity;
using HrManagementSystem.Persistence.Interfaces.Services;
using HrManagemntSystem.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagemntSystem.Application.Interfaces.Services
{
    public interface IStatusService:IBaseService<StatusEntity>
    {
        Task<bool> AddStatus(StatusDto entity);
    }
}
