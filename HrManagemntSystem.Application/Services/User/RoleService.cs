using AutoMapper;
using HrManagementSystem.Domain.Entities.Identity;
using HrManagementSystem.Persistence.Interfaces.Services;
using HrManagemntSystem.Application.Dtos.Users;
using HrManagemntSystem.Application.Interfaces.Services.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagementSystem.Persistence.Services.User
{
    public class RoleService : IRoleService
    {
        private readonly RoleManager<AppRoleEntity> _roleManager;
        private readonly IBaseService<AppRoleEntity> _roleService;
        private readonly UserManager<AppUserEntity> _userManager;

        public RoleService(RoleManager<AppRoleEntity> roleManager, IBaseService<AppRoleEntity> roleService, UserManager<AppUserEntity> userManager)
        {
            _roleManager = roleManager;
            _roleService = roleService;
            _userManager = userManager;
        }

        public async Task<AppRoleEntity> GetRoleById(int id)
        {
            return await _roleService.FindByIdAsync(id);
        }

        public IList<AppRoleEntity> GetRoleList()
        {
            return _roleService.GetAll().Where(x => !x.IsDeleted).ToList();
        }

        public async Task<CreateRoleResponseDto> SaveRole(CreateRoleDto role)
        {
            var existingRole = await _roleManager.FindByNameAsync(role.Name);
            if (existingRole != null)
            {
                return new CreateRoleResponseDto
                {
                    success = false,
                    message = "Bu adla rol artıq mövcuddur."
                };
            }

            var identityResult = await _roleManager.CreateAsync(new AppRoleEntity
            {
                Name = role.Name
            });

            if (identityResult.Succeeded)
            {
                return new CreateRoleResponseDto
                {
                    success = true,
                    message = "Rol uğurla yaradıldı"
                };
            }

            var errorMessages = string.Join(", ", identityResult.Errors.Select(e => e.Description));
            return new CreateRoleResponseDto
            {
                success = false,
                message = $"Rol yaradılarkən səhv baş verdi: {errorMessages}"
            };
        }

        public async Task<List<UserRoleDto>> GetUserRoles(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                throw new Exception("İstifadəçi tapılmadı.");
            }

            var allRoles = await _roleManager.Roles.ToListAsync();
            var userRoles = await _userManager.GetRolesAsync(user);

            var userRoleDtos = allRoles.Select(role => new UserRoleDto
            {
                HasAssign = userRoles.Contains(role.Name),
                RoleId = role.Id,
                RoleName = role.Name
            }).ToList();

            return userRoleDtos;
        }
    }

}
