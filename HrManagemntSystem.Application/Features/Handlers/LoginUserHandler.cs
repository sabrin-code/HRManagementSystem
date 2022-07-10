using HrManagementSystem.Domain.Entities.Identity;
using HrManagemntSystem.Application.Abstraction.Token;
using HrManagemntSystem.Application.Dtos;
using HrManagemntSystem.Application.Dtos.Users;
using HrManagemntSystem.Application.Features.Requests;
using HrManagemntSystem.Application.Features.Results;
using HrManagemntSystem.Application.Interfaces.Services.Users;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagemntSystem.Application.Features.Handlers
{
    public class LoginUserHandler : IRequestHandler<LoginUserRequest, LoginUserResutl>
    {
        private readonly IAuthService _authService;
        public LoginUserHandler(IAuthService authService)
        {
            _authService=authService;
        }
        public async Task<LoginUserResutl> Handle(LoginUserRequest request, CancellationToken cancellationToken)
        {

            LoginUserResponseDto loginUserResponse = await _authService.LoginUser(new()
            {
                Username=request.Username,
                Password=request.Password,
                Email=request.Email
            });
            return new()
            {

                message=loginUserResponse.message,
                success=loginUserResponse.success,
                Token=loginUserResponse.Token
            };
        }
    }
}
