using HrManagemntSystem.Application.Features.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagemntSystem.Application.Dtos
{
    public class CreateUserRequest:IRequest<CreateUserResult>
    {
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string MiddleName { get; set; }
        public int Id { get; set; }
        public int EmployeeId { get; set; }
    }
}
