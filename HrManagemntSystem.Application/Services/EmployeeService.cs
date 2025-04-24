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
    public class EmployeeService:BaseService<EmployeeEntity>,IEmployeeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public EmployeeService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork)
        {
            _unitOfWork=unitOfWork;
            _mapper=mapper;

        }
        public List<EmployeeDto> GetAllEmployee()
        {
            var data = GetAll().Where(x => x.IsDeleted==false).ToList();
            return _mapper.Map<List<EmployeeDto>>(data);
        }

        public async Task<EmployeeDto> FindEmployeeById(int id)
        {

            var result = await FindByIdAsync(id);

            if (result==null)
            {
                throw new Exception("Isci tapilmadi");
            }
            return _mapper.Map<EmployeeDto>(result);
        }
        public async Task<bool> AddEmployee(EmployeeDto entity)
        {
            var mapdata = _mapper.Map<EmployeeEntity>(entity);
             await CreateAsync(mapdata);
            _unitOfWork.Commit();
            return true;
        }

        public async Task<bool> DeleteEmployeeById(int id)
        {
            var data = await FindByIdAsync(id);
            if (data.IsDeleted==false)
            {
                data.IsDeleted=true;
            }
            _unitOfWork.Commit();
            return true;
        }
        public async Task<bool> UpdateEmployee(EmployeeDto entity)
        {
            var mapdata = _mapper.Map<EmployeeEntity>(entity);
             await UpdateAsync(mapdata);
            _unitOfWork.Commit();
            return true;
        }
        public async Task<EmployeeDto>FindEmployeeByPositionId(int positionId)
        {
            var data= Find(x=>x.PositionId==positionId);
            if (data==null)
            {
                throw new Exception("Isci tapilmadi");
            }
            return _mapper.Map<EmployeeDto>(data);
        } 



    }
}
