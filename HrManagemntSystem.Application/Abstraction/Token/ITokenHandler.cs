using HrManagemntSystem.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagemntSystem.Application.Abstraction.Token
{
    public interface ITokenHandler
    {
        AccessTokenDto CreateAccessToken(int min);
    }
}
