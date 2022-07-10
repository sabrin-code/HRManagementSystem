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
    public interface IVacancyDaysService: IBaseService<VacationDaysEntity>
    {
        List<VacancyDaysDto> GetAllVacancyDays();
        Task<VacancyDaysDto> FindVacancyDaysById(int id);
        Task<bool> AddVacancyDays(VacancyDaysDto entity);
        Task<bool> DeleteVacancyDaysById(int id);
        Task<bool> UpdateVacancyDays(VacancyDaysDto entity);
        Task<VacancyDaysDto> FindDayByPositionId(int positionId);
    }
}
