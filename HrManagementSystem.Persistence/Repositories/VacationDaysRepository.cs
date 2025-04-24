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
    public class VacationDaysRepository:CRUDRepository<VacationDaysEntity>,IVacationDaysRepository
    {
        public VacationDaysRepository(HRDbContext context):base(context)
        {

        }
    }
}
