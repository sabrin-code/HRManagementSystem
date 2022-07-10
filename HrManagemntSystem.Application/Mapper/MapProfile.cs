using AutoMapper;
using HrManagementSystem.Domain.Entities;
using HrManagementSystem.Domain.Entities.Identity;
using HrManagemntSystem.Application.Dtos;
using HrManagemntSystem.Application.Dtos.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagemntSystem.Application.Mapper
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<AppRoleEntity, CreateRoleDto>();
            CreateMap<DepartamentEntity, DepartamentDto>();
            CreateMap<DepartamentDto, DepartamentEntity>();
            CreateMap<PositionDto, PositionEntity>();
            CreateMap<PositionEntity, PositionDto>();
            CreateMap<VacancyAppDto, VacationApplicationEntity>();
            CreateMap<VacationApplicationEntity, VacancyAppDto>();
            CreateMap<VacancyDaysDto, VacationDaysEntity>();
            CreateMap<VacationDaysEntity,VacancyDaysDto>(); 
            CreateMap<StatusEntity,StatusDto>();
            CreateMap<StatusDto,StatusEntity>();   
            CreateMap<EmployeeDto, EmployeeEntity>();
            CreateMap<EmployeeEntity, EmployeeDto>();
        }
    }
}
