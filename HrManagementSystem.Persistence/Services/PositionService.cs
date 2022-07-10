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
    public class PositionService : BaseService<PositionEntity>, IPositionService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public PositionService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork)
        {
            _unitOfWork=unitOfWork;
            _mapper=mapper;

        }
        public List<PositionDto> GetAllPosition()
        {
            var data = GetAll().Where(x => x.IsDeleted==false).ToList();
            return _mapper.Map<List<PositionDto>>(data);
        }

        public async Task<PositionDto> FindPositionById(int id)
        {

            var result = await FindByIdAsync(id);

            if (result==null)
            {
                throw new Exception("Bolme tapilmadi");
            }
            return _mapper.Map<PositionDto>(result);
        }
        public async Task<bool> AddPosition(PositionDto entity)
        {
            var mapdata = _mapper.Map<PositionEntity>(entity);
             await CreateAsync(mapdata);
             await SaveAsync();
            return true;    
        }

        public async Task<bool> DeletePositionById(int id)
        {
            var data = await FindByIdAsync(id);
            if (data.IsDeleted==false)
            {
                data.IsDeleted=true;
            }
           await  SaveAsync();
            return true;
        }
        public async Task<bool> UpdatePosition(PositionDto entity)
        {
            var mapdata = _mapper.Map<PositionEntity>(entity);
             await UpdateAsync(mapdata);
            await SaveAsync();
            return true;
        }


    
}
}
