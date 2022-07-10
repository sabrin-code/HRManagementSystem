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
    public class DepartamentService:BaseService<DepartamentEntity>,IDepartamentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public DepartamentService(IUnitOfWork unitOfWork):base(unitOfWork)
        {
            _unitOfWork=unitOfWork;

        }

        public List<DepartamentDto> GetAllDepartament()
        {
            var data=  GetAll().Where(x => x.IsDeleted==false).ToList();
            return  _mapper.Map<List<DepartamentDto>>(data);    
        }

        public async Task<DepartamentDto>FindDepartamentById(int id)
        {
            
            var result=  await  FindByIdAsync(id);
            
            if (result==null)
            {
                throw new Exception("Bolme tapilmadi");
            }
            return  _mapper.Map<DepartamentDto>(result);
        }
        public async Task<bool>AddDepartament(DepartamentDto entity)
        {
            var mapdata=_mapper.Map<DepartamentEntity>(entity); 
             await CreateAsync(mapdata);
            await SaveAsync();
            return true;
        }

        public async Task<bool> DeleteDepartamentById(int id)
        {         
            var data = await  FindByIdAsync(id);
            if (data.IsDeleted==false)
            {
                data.IsDeleted=true;
            }
            await SaveAsync();
            return true;
        }
        public async Task<bool>UpdateDepartament(DepartamentDto entity)
        {
            var mapdata=_mapper.Map<DepartamentEntity>(entity);    
             await  UpdateAsync(mapdata);
            await SaveAsync();
            return true;
        }  

    }
}
