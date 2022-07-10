using AutoMapper;
using HrManagementSystem.Domain.Entities.Identity;
using HrManagemntSystem.Application.Dtos.Users;
using HrManagemntSystem.Application.Interfaces.Services.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRManagementSystem.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : BaseController
    {
        private readonly IRoleService _roleService;
        private readonly IMapper _mapper;
        public RoleController(IRoleService roleService, IMapper mapper)
        {
            _roleService = roleService;
            _mapper=mapper;    
        }

        [HttpGet("GetRoleById")]
        public async Task<CreateRoleDto> GetRoleById(int id)
        {
            var result= await _roleService.GetRoleById(id); 
            return _mapper.Map<CreateRoleDto>(result); 

        }
        [HttpGet("GetRoleList")]
        public IList<CreateRoleDto> GetRoleList()
        {
            var result = _roleService.GetRoleList();
            if (result==null)
            {
                throw new Exception("Data is not found");
            }
            return _mapper.Map<IList<CreateRoleDto>>(result);
        }
        [HttpPost("SaveRole")]
        public async Task<CreateRoleResponseDto> SaveRole(CreateRoleDto role)
        {
            return await _roleService.SaveRole(role);   
        }

        [HttpGet("GetUserRoles")]
        public async Task<List<UserRoleDto>> GetUserRoles(string id)
        {
            return await _roleService.GetUserRoles(id);
        }
      
    }
}
