using HrManagementSystem.Domain.Entities.Identity;
using HrManagemntSystem.Application.Dtos.Users;
using HrManagemntSystem.Application.Interfaces.Services.Users;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagementSystem.Persistence.Services.User
{
    public class UserService : IUserService
    {
        private readonly UserManager<AppUserEntity> _userManager;
        public UserService(UserManager<AppUserEntity> userManager)
        {
            _userManager = userManager;
        }
        public async Task<CreateUserResponseDto> CreateUser(CreateUserDto request)
        {
            IdentityResult result = await _userManager.CreateAsync(new()
            {
                UserName=request.Username,
                Id=request.Id,
                Name = request.Name,
                Surname = request.Surname,
                Email=request.Email,
                MiddleName=request.MiddleName,
                EmployeeId=request.EmployeeId,  
                
            }, request.Password);
            if (result.Succeeded)
            {
                return new()
                {
                    succcess = true,
                    message ="Success"
                };
            }
            else
            {
                return new()
                {
                    succcess= false,
                    message ="UnSuccess"
                };
            }

        }

    }

}
