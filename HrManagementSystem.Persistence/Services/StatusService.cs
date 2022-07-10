using AutoMapper;
using HrManagementSystem.Domain.Entities.Identity;
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
    public class StatusService:BaseService<StatusEntity>,IStatusService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public StatusService(IUnitOfWork unitOfWork, IMapper mapper) :base(unitOfWork)
        {
            _unitOfWork=unitOfWork;
            _mapper=mapper;
        }
        public async Task<bool> AddStatus(StatusDto entity)
        {
            var mapdata = _mapper.Map<StatusEntity>(entity);
             await CreateAsync(mapdata);
            await SaveAsync();
            return true;
        }
    }
}
