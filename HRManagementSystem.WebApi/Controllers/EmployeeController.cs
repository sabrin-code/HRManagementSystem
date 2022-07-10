using HrManagemntSystem.Application.Dtos;
using HrManagemntSystem.Application.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRManagementSystem.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : BaseController
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;

        }

        [HttpGet("GetAllEmployee")]
        public List<EmployeeDto> GetAllEmployee()
        {

            return _employeeService.GetAllEmployee();

        }

        [HttpGet("FindEmployeeById")]
        public async Task<EmployeeDto> FindEmployeeById(int id)
        {
            return await _employeeService.FindEmployeeById(id);
        }

        [HttpPost("AddEmployee")]
        public async Task<bool> AddEmployee(EmployeeDto entity)
        {
            return await _employeeService.AddEmployee(entity);
        }

        [HttpPost("DeleteEmployeeById")]
        public async Task DeleteEmployeeById(int id)
        {
            await _employeeService.DeleteEmployeeById(id);
        }

        [HttpPost("UpdateEmployee")]
        public async Task<bool> UpdateEmployee(EmployeeDto entity)
        {
            return await _employeeService.UpdateEmployee(entity);
        }

        [HttpGet("FindEmployeeByPositionId")]

        public async Task<EmployeeDto> FindEmployeeByPositionId(int positionId)
        {
            return await _employeeService.FindEmployeeByPositionId(positionId);
        }

    }
}
