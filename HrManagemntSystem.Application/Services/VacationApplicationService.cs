using AutoMapper;
using HrManagementSystem.Domain.Constants;
using HrManagementSystem.Domain.Entities;
using HrManagementSystem.Domain.Entities.Identity;
using HrManagementSystem.Persistence.Interfaces.Services;
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
    public class VacationApplicationService:BaseService<VacationApplicationEntity>,IVacationAppService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IBaseService<AppUserEntity> _userService;
        private readonly IBaseService<AppUserRoleEntity> _roleService;
        private readonly IBaseService<PositionEntity> _positionService;
        public VacationApplicationService(IUnitOfWork unitOfWork, IBaseService<AppUserEntity> userService, IMapper mapper, 
            IBaseService<AppUserRoleEntity> roleService, IBaseService<PositionEntity> positionService) : base(unitOfWork)
        {
            _unitOfWork=unitOfWork;
            _mapper=mapper;
            _userService=userService;
            _roleService=roleService;
            _positionService=positionService;

        }

        public List<VacancyAppDto> GetAllVacancyApp()
        {
            var userRoles = _roleService.GetAll().Where(x => x.IsDeleted==false).ToList();
            if (userRoles.Count>0)
            {
                foreach (var item in userRoles)
                {
                    if (item.RoleId==2)
                    {

                        var row = from document in GetAll()
                                  join user in _userService.GetAll() on document.EmployeeId equals user.EmployeeId
                                  where document.IsDeleted == false
                                  select new VacancyAppDto
                                  {
                                      EmployeeId=user.EmployeeId,
                                      StatusId=document.StatusId,
                                      StartDate=document.StartDate,
                                      Count=document.Count,

                                  };
                        return _mapper.Map<List<VacancyAppDto>>(row);

                    }
                    else if (item.RoleId==3)
                    {
                        var data = GetAll().Where(x => x.IsDeleted==false).ToList();
                        return _mapper.Map<List<VacancyAppDto>>(data);
                    }
                }

            }
            return new List<VacancyAppDto>();


        }

       
        public async Task<bool> AddVacancyApp(VacancyAppDto entity)
        {
            var mapdata = _mapper.Map<VacationApplicationEntity>(entity);
            mapdata.Status.StatusKey=StatusKeys.NewApplication;
            await CreateAsync(mapdata);
            await SaveAsync();
            return true;
        }

       
        public async Task<bool> UpdateVacancyApp(VacancyAppDto entity)
        {
            var mapdata = _mapper.Map<VacationApplicationEntity>(entity);
             await UpdateAsync(mapdata);
            await SaveAsync();
            return true;
        }
        public async Task<bool>CancelApp(VacancyAppDto entity)
        {
            var mapdata = _mapper.Map<VacationApplicationEntity>(entity);
             mapdata.Status.StatusKey=StatusKeys.CancelDocument;
             await UpdateAsync(mapdata);
            await SaveAsync();
            return true;
        }

        public async Task<bool> ConfirmApp(VacancyAppDto entity)
        {
            var mapdata = _mapper.Map<VacationApplicationEntity>(entity);
            mapdata.Status.StatusKey=StatusKeys.ConfirmDocument;
            await UpdateAsync(mapdata);
            await SaveAsync();
            return true;
        }



    }
}
