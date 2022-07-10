using HrManagementSystem.Domain.Entities;
using HrManagementSystem.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagementSystem.Persistence.Context
{
    public  class HRDbContext : IdentityDbContext<AppUserEntity, AppRoleEntity, int, IdentityUserClaim<int>, AppUserRoleEntity ,
        IdentityUserLogin<int>,IdentityRoleClaim<int>,IdentityUserToken<int>>
    {
        public HRDbContext(DbContextOptions options):base(options)  
        {

        }
        public DbSet<DepartamentEntity>Departaments { get; set; }   
        public  DbSet<EmployeeEntity>Employees { get; set; }  
        public DbSet<PositionEntity>Positions { get; set; }
        public DbSet<VacationApplicationEntity> VacationApplications { get; set; }
        public DbSet<VacationDaysEntity> VacationDays { get; set; }
        public DbSet<StatusEntity> Status { get; set; }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return base.SaveChangesAsync(cancellationToken);
        }



    }
}
