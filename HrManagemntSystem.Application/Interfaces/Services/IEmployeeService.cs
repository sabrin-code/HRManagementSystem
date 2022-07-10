using HrManagementSystem.Domain.Entities;
using HrManagementSystem.Persistence.Interfaces.Services;
using HrManagemntSystem.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagemntSystem.Application.Interfaces.Services
{
    public interface IEmployeeService:IBaseService<EmployeeEntity>
    {
        List<EmployeeDto> GetAllEmployee();
        Task<EmployeeDto> FindEmployeeById(int id);
        Task<bool> AddEmployee(EmployeeDto entity);
        Task<bool> DeleteEmployeeById(int id);
        Task<bool> UpdateEmployee(EmployeeDto entity);
        Task<EmployeeDto> FindEmployeeByPositionId(int positionId);
    }
}
