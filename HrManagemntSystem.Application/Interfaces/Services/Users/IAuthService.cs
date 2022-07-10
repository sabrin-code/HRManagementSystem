﻿using HrManagemntSystem.Application.Dtos.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagemntSystem.Application.Interfaces.Services.Users
{
    public interface IAuthService
    {
        Task<LoginUserResponseDto> LoginUser(LoginUserDto req);
    }
}
