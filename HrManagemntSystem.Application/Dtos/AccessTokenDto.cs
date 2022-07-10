using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagemntSystem.Application.Dtos
{
    public class AccessTokenDto
    {
        public DateTime Expiration { get; set; }
        public string AccessToken { get; set; }
    }
}
