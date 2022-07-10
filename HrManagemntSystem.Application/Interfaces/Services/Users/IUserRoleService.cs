using HrManagementSystem.Domain.Entities.Identity;
using HrManagementSystem.Persistence.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagemntSystem.Application.Interfaces.Services.Users
{
    public interface IUserRoleService:IBaseService<AppUserRoleEntity>
    {
        Task<bool> SaveRoleToUser(int userId, int[] roleid);
    }
}
