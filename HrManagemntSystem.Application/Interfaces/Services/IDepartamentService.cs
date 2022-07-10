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
    public interface IDepartamentService : IBaseService<DepartamentEntity>
    {
        List<DepartamentDto> GetAllDepartament();
        Task<DepartamentDto> FindDepartamentById(int id);
        Task<bool> AddDepartament(DepartamentDto entity);
        Task<bool> DeleteDepartamentById(int id);
        Task<bool> UpdateDepartament(DepartamentDto entity);

    }
}
