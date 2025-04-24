using AutoMapper;
using HrManagementSystem.Domain.Entities;
using HrManagementSystem.Persistence.Services.Base;
using HrManagemntSystem.Application.Dtos;
using HrManagemntSystem.Application.Interfaces.Services;
using HrManagemntSystem.Application.Interfaces.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagementSystem.Persistence.Services
{
    public class VacationDaysService:BaseService<VacationDaysEntity>,IVacancyDaysService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public VacationDaysService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork)
        {
            _unitOfWork=unitOfWork;
            _mapper=mapper;

        }

      

        public List<VacancyDaysDto> GetAllVacancyDays()
        {
            var data = GetAll().Where(x => x.IsDeleted==false).ToList();
            return _mapper.Map<List<VacancyDaysDto>>(data);
        }

        public async Task<VacancyDaysDto> FindVacancyDaysById(int id)
        {

            var result = await FindByIdAsync(id);

            if (result==null)
            {
                throw new Exception("Data is not found");
            }
            return _mapper.Map<VacancyDaysDto>(result);
        }
        public async Task<bool> AddVacancyDays(VacancyDaysDto entity)
        {
            var mapdata = _mapper.Map<VacationDaysEntity>(entity);
             await CreateAsync(mapdata);
            _unitOfWork.Commit();
            return true;
        }

        public async Task<bool> DeleteVacancyDaysById(int id)
        {
            var data = await FindByIdAsync(id);
            if (data.IsDeleted==false)
            {
                data.IsDeleted=true;
            }
           _unitOfWork.Commit();
            return true;
        }
        public async Task<bool> UpdateVacancyDays(VacancyDaysDto entity)
        {
            var mapdata = _mapper.Map<VacationDaysEntity>(entity);
             await UpdateAsync(mapdata);
            _unitOfWork.Commit();
            return true;
        }

        public async Task<VacancyDaysDto> FindDayByPositionId(int positionId)
        {
            var data = Find(x => x.Id==positionId);
            if (data==null)
            {
                throw new Exception("Data is not found");
            }
            return _mapper.Map<VacancyDaysDto>(data);
        }
    }
}
