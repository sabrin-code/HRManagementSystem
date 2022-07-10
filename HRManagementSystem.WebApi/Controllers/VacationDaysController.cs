using AutoMapper;
using HrManagemntSystem.Application.Dtos;
using HrManagemntSystem.Application.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRManagementSystem.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VacationDaysController : BaseController
    {
        
        private readonly IVacancyDaysService _vacancyDaysService;
        public VacationDaysController(IMapper mapper, IVacancyDaysService vacancyDaysService)
        {
            
           
            _vacancyDaysService = vacancyDaysService;
        }

        [HttpGet("GetAllVacancyDays")]
        public List<VacancyDaysDto> GetAllVacancyDays()
        {

            return _vacancyDaysService.GetAllVacancyDays();

        }

        [HttpGet("FindVacancyDayById")]
        public async Task<VacancyDaysDto> FindVacancyDayById(int id)
        {
            return await _vacancyDaysService.FindVacancyDaysById(id);
        }

        [HttpPost("AddDays")]
        public async Task<bool> AddDays(VacancyDaysDto entity)
        {
            return await _vacancyDaysService.AddVacancyDays(entity);
        }

        [HttpPost("DeleteDayById")]
        public async Task DeleteDayById(int id)
        {
            await _vacancyDaysService.DeleteVacancyDaysById(id);
        }

        [HttpPost("UpdateDay")]
        public async Task<bool> UpdateDay(VacancyDaysDto entity)
        {
            return await _vacancyDaysService.UpdateVacancyDays(entity);
        }

        [HttpGet("FindDayByPositionId")]

        public async Task<VacancyDaysDto> FindDayByPositionId(int positionId)
        {
            return await _vacancyDaysService.FindDayByPositionId(positionId);
        }


    }
}
