using HrManagementSystem.Domain.Entities.Identity;
using HrManagemntSystem.Application.Abstraction.Token;
using HrManagemntSystem.Application.Dtos;
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
    public class AuthServise : IAuthService
    {
        private readonly UserManager<AppUserEntity> _userManager;
        private readonly SignInManager<AppUserEntity> _signInManager;
        private readonly ITokenHandler _handler;
        public AuthServise(UserManager<AppUserEntity> userManager, SignInManager<AppUserEntity> signInManager, ITokenHandler handler)
        {
            _userManager = userManager;
            _signInManager=signInManager;
            _handler=handler;
        }

        public async Task<LoginUserResponseDto> LoginUser(LoginUserDto request)
        {
            var user = await _userManager.FindByNameAsync(request.Username);
            if (user == null)

                user=await _userManager.FindByEmailAsync(request.Email);
            if (user==null)
            {
                throw new Exception("Istifadeci tapilmadi");
            }
            SignInResult result = await _signInManager.CheckPasswordSignInAsync(user, request.Password, false);
            if (result.Succeeded)
            {
                AccessTokenDto token = _handler.CreateAccessToken(user);
                return new()
                {
                    Token=token,
                    success = true,
                    message =""
                };
            }
            return new();

        }
    }
}
