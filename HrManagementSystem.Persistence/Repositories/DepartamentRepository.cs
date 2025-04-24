using HrManagementSystem.Domain.Entities;
using HrManagementSystem.Persistence.Context;
using HrManagemntSystem.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagementSystem.Persistence.Repositories
{
    public class DepartamentRepository:CRUDRepository<DepartamentEntity>,IDepartamentRepository
    {
        public DepartamentRepository(HRDbContext context):base(context) 
        {

        }
    }
}
