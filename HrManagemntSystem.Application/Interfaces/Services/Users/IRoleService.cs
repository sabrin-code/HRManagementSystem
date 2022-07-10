using HrManagementSystem.Domain.Entities.Identity;
using HrManagemntSystem.Application.Dtos.Users;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagemntSystem.Application.Interfaces.Services.Users
{
    public interface IRoleService
    {
        IList<AppRoleEntity> GetRoleList();
        Task<AppRoleEntity> GetRoleById(int id);
        Task<CreateRoleResponseDto> SaveRole(CreateRoleDto role);        
        Task<List<UserRoleDto>> GetUserRoles(string id);

    }
}
