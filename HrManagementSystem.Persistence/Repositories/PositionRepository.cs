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
    public class PositionRepository:CRUDRepository<PositionEntity>,IPositionRepository
    {
        public PositionRepository(HRDbContext context):base(context)
        {

        }
    }
}
