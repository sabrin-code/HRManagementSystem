using HrManagementSystem.Domain.Entities;
using HrManagementSystem.Persistence.Context;
using HrManagemntSystem.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagementSystem.Persistence.Repositories
{
    public class EmployeeRepository:CRUDRepository<EmployeeEntity>,IEmployeeRepository
    {
        public EmployeeRepository(HRDbContext context):base(context)
        {

        }
    }
}
