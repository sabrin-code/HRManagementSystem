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
            if (request.Password != request.ConfirmPassword)
            {
                return new()
                {
                    succcess = false,
                    message = "Şifrələr uyğun deyil"
                };
            }

            var user = new AppUserEntity
            {
                UserName = request.Username,
                Name = request.Name,
                Surname = request.Surname,
                Email = request.Email,
                MiddleName = request.MiddleName,
                EmployeeId = request.EmployeeId,
            };

            IdentityResult result = await _userManager.CreateAsync(user, request.Password);

            if (result.Succeeded)
            {
                return new()
                {
                    succcess = true,
                    message = "İstifadəçi uğurla yaradıldı"
                };
            }
            else
            {
                string errors = string.Join(" | ", result.Errors.Select(e => e.Description));
                return new()
                {
                    succcess = false,
                    message = $"Xəta baş verdi: {errors}"
                };
            }
        }


    }
