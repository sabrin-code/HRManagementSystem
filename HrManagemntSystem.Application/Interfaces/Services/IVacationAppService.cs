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
    public interface IVacationAppService: IBaseService<VacationApplicationEntity>
    {
        List<VacancyAppDto> GetAllVacancyApp();
        Task<bool> AddVacancyApp(VacancyAppDto entity);
        Task<bool> UpdateVacancyApp(VacancyAppDto entity);
        Task<bool> CancelApp(VacancyAppDto entity);
        Task<bool> ConfirmApp(VacancyAppDto entity);

    }
}
