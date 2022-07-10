using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagemntSystem.Application.Dtos.Users
{
    public class LoginUserResponseDto
    {
        public string message { get; set; }
        public bool success { get; set; }
        public AccessTokenDto Token { get; set; }
    }
}
