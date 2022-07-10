using HrManagemntSystem.Application.Dtos;
using HrManagemntSystem.Application.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRManagementSystem.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VacancyAppController : BaseController
    {
        private readonly IVacationAppService _vacancyAppService;
        public VacancyAppController(IVacationAppService vacancyAppService)
        {
            _vacancyAppService = vacancyAppService;
        }
        [HttpGet("GetAllVacancyApp")]   
        public List<VacancyAppDto> GetAllVacancyApp()
        {
            return _vacancyAppService.GetAllVacancyApp();   
        }

        [HttpPost("AddVacancyApp")]
        public async Task<bool> AddVacancyApp(VacancyAppDto entity)
        {
            return await  _vacancyAppService.AddVacancyApp(entity);
        }
        [HttpPost("UpdateVacancyApp")]
        public async Task<bool> UpdateVacancyApp(VacancyAppDto entity)
        {
            return await _vacancyAppService.UpdateVacancyApp(entity);
        }
        [HttpPost("CancelApp")]
        public async Task<bool> CancelApp(VacancyAppDto entity)
        {
            return await _vacancyAppService.CancelApp(entity);  
        }
        [HttpPost("ConfirmApp")]
        public async Task<bool> ConfirmApp(VacancyAppDto entity)
        {
            return await _vacancyAppService.ConfirmApp(entity); 
        }
    }
}
