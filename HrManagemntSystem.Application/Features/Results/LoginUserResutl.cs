using HrManagemntSystem.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagemntSystem.Application.Features.Results
{
    public class LoginUserResutl
    {
        public string message { get; set; }
        public bool success { get; set; }
        public AccessTokenDto Token { get; set; }
    }
}
