using AutoMapper;
using HrManagementSystem.Domain.Entities;
using HrManagemntSystem.Application.Dtos;
using HrManagemntSystem.Application.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRManagementSystem.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentController : BaseController
    {
        private readonly IDepartamentService _departamentService;
       
        public DepartamentController(IDepartamentService departamentService)
        {
            _departamentService = departamentService;   
            
        }

        [HttpGet("GetAllDepartament")]
        public  List<DepartamentDto> GetAllDepartament()
        {
            
           return  _departamentService.GetAllDepartament();
            
        }

        [HttpGet("FindDepartamentById")]
        public async Task<DepartamentDto> FindDepartamentById(int id)
        {
            return await _departamentService.FindDepartamentById(id);
        }

        [HttpPost("AddDepartament")]
        public async Task<bool> AddDepartament(DepartamentDto entity)
        {
             return await _departamentService.AddDepartament(entity);   
        }

         [HttpPost("DeleteDepartamentById")]
        public async Task  DeleteDepartamentById(int id)
        {
           await _departamentService.DeleteDepartamentById(id);
        }
        [HttpPost("UpdateDepartament")]
        public async Task<bool> UpdateDepartament(DepartamentDto entity)
        {
            return await _departamentService.UpdateDepartament(entity);
        }


    }
}
