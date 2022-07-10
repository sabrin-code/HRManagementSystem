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
    public interface IPositionService: IBaseService<PositionEntity>
    {
        List<PositionDto> GetAllPosition();
        Task<PositionDto> FindPositionById(int id);
        Task<bool> AddPosition(PositionDto entity);
        Task<bool> DeletePositionById(int id);
        Task<bool> UpdatePosition(PositionDto entity);
    }
}
