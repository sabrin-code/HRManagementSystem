using HrManagemntSystem.Application.Interfaces.Services.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRManagementSystem.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRoleController : BaseController
    {
        private readonly IUserRoleService _userRoleService;
        public UserRoleController(IUserRoleService userRoleService)
        {
            _userRoleService = userRoleService; 
        }
        [HttpPost("SaveRoleToUser")]
        public async Task<bool> SaveRoleToUser(int userId, int[] roleid)
        {
            return await _userRoleService.SaveRoleToUser(userId, roleid);
        }
    }
}
