using HrManagemntSystem.Application.Dtos;
using HrManagemntSystem.Application.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRManagementSystem.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : BaseController
    {
        private readonly IStatusService _statusService;
       
        public StatusController(IStatusService statusService)
        {
            _statusService = statusService;
        }

        [HttpPost("AddStatus")]
        public async Task<bool> AddStatus(StatusDto entity)
        {
            return await _statusService.AddStatus(entity);
        }

    }
}
