using AutoMapper;
using HrManagementSystem.Domain.Entities.Identity;
using HrManagementSystem.Persistence.Interfaces.Services;
using HrManagemntSystem.Application.Dtos.Users;
using HrManagemntSystem.Application.Interfaces.Services.Users;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagementSystem.Persistence.Services.User
{
    public class RoleService:IRoleService
    {
        private readonly RoleManager<AppRoleEntity> _roleManager;
        private readonly IBaseService<AppRoleEntity> _roleService;
        private readonly UserManager<AppUserEntity> _userManager;
        public RoleService(RoleManager<AppRoleEntity> roleManager ,IBaseService<AppRoleEntity> roleService, UserManager<AppUserEntity> userManager)
        {
            _roleManager = roleManager;
            _roleService=roleService;
            _userManager=userManager;

        }

        public async Task<AppRoleEntity> GetRoleById(int id)
        {
            return await _roleService.FindByIdAsync(id);
          
            
        }

        public IList<AppRoleEntity> GetRoleList()
        {

            return _roleService.GetAll().Where(x => x.IsDeleted==false).ToList(); ;
        }

        public async Task<CreateRoleResponseDto> SaveRole(CreateRoleDto role)
        {

            IdentityResult identityResult = await _roleManager.CreateAsync(new()
            {
                
                Name=role.Name,
                Id = role.Id,

            });
            if (identityResult.Succeeded)
            {
                return new()
                {
                    success= true,
                    message="Success"
                };
                 
            }
            else
            {
                return new()
                {
                    success= false,
                    message ="UnSuccess"
                };
            }

        }
        public async Task<List<UserRoleDto>>GetUserRoles(string id)
        {
            AppUserEntity user = await _userManager.FindByIdAsync(id);
            List<AppRoleEntity> allRoles = _roleManager.Roles.ToList();
            List<string> userRoles = await _userManager.GetRolesAsync(user) as List<string>;
            List<UserRoleDto> assignRoles = new List<UserRoleDto>();
            allRoles.ForEach(role => assignRoles.Add(new UserRoleDto
            {
                HasAssign = userRoles.Contains(role.Name),
                RoleId = role.Id,
                RoleName = role.Name
            }));

            return assignRoles;
        }

     


    }
}
