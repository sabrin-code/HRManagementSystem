using HrManagemntSystem.Application.Dtos;
using HrManagemntSystem.Application.Features.Requests;
using HrManagemntSystem.Application.Features.Results;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRManagementSystem.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : BaseController
    {
        private readonly IMediator _mediator;
        public UserController(IMediator mediator)
        {
            _mediator = mediator;   
        }
        [HttpPost("CreateUser")]

        public async Task<CreateUserResult>CreateUser(CreateUserRequest request)
        {
            return await  _mediator.Send(request);
        }
        [HttpPost("SignInUser")]
        public async Task<LoginUserResutl> SignInUser(LoginUserRequest request)
        {
            return await _mediator.Send(request);
        }
    }
}
