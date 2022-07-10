using HrManagementSystem.Domain.Entities.Identity;
using HrManagemntSystem.Application.Dtos;
using HrManagemntSystem.Application.Dtos.Users;
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
    public class CreateUserHandler : IRequestHandler<CreateUserRequest, CreateUserResult>
    {
        private readonly IUserService _userService;
        public CreateUserHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<CreateUserResult> Handle(CreateUserRequest request, CancellationToken cancellationToken)
        {
            CreateUserResponseDto createUserResponse= await _userService.CreateUser(new()
            {
                Email = request.Email,  
                Username=request.Username,
                Name = request.Name,    
                Surname=request.Surname,    
                Password=request.Password,  
                MiddleName=request.MiddleName,
                ConfirmPassword=request.ConfirmPassword,   
                EmployeeId=request.EmployeeId,  
                

            });
            return new()
            {
                message=createUserResponse.message,
                succcess=createUserResponse.succcess,
            };
        
        }
           

    }
}

