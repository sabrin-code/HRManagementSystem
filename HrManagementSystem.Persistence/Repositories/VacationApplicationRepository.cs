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
    public class VacationApplicationRepository:CRUDRepository<VacationApplicationEntity>, IVacationApplicationRepository
    {
        public VacationApplicationRepository(HRDbContext context):base(context)
        {

        }
    }
}
