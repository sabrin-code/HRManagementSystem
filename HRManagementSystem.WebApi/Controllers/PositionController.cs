using HrManagemntSystem.Application.Dtos;
using HrManagemntSystem.Application.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRManagementSystem.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PositionController : BaseController
    {
        private readonly IPositionService _positionService;
        public PositionController(IPositionService positionService)
        {
            _positionService = positionService;
           
        }

        [HttpGet("GetAllPosition")]
        public List<PositionDto> GetAllPosition()
        {

            return _positionService.GetAllPosition();

        }

        [HttpGet("FindPositionById")]
        public async Task<PositionDto> FindPositionById(int id)
        {
            return await _positionService.FindPositionById(id);
        }

        [HttpPost("AddPosition")]
        public async Task<bool> AddPosition(PositionDto entity)
        {
            return await _positionService.AddPosition(entity);
        }

        [HttpPost("DeletePositionById")]
        public async Task DeletePositionById(int id)
        {
            await _positionService.DeletePositionById(id);
        }
        [HttpPost("UpdatePosition")]
        public async Task<bool> UpdatePosition(PositionDto entity)
        {
            return await _positionService.UpdatePosition(entity);
        }

    }
}
