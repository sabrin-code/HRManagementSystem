using HrManagementSystem.Domain.Entities.Identity;
using HrManagementSystem.Persistence.Context;
using HrManagementSystem.Persistence.Interfaces.Services;
using HrManagementSystem.Persistence.Repositories;
using HrManagementSystem.Persistence.Services;
using HrManagementSystem.Persistence.Services.Base;
using HrManagementSystem.Persistence.Services.User;
using HrManagementSystem.Persistence.UnitOfWork;
using HrManagemntSystem.Application.Interfaces.Repositories.BaseRepository;
using HrManagemntSystem.Application.Interfaces.Services;
using HrManagemntSystem.Application.Interfaces.Services.Users;
using HrManagemntSystem.Application.Interfaces.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagementSystem.Persistence
{
    public static class ServiceRegister
    {
        public static void AddPersistenceServices( this IServiceCollection service)
        {
            service.AddDbContext<HRDbContext>(x => x.UseSqlServer(Configure.ConnectionString));
            service.AddIdentity<AppUserEntity, AppRoleEntity>(options =>
            {
                options.Password.RequiredLength = 6;
                options.Password.RequireUppercase = true;
                options.Password.RequireDigit=true;
                options.Password.RequireNonAlphanumeric = false;
                
                

                
            }).AddEntityFrameworkStores<HRDbContext>();
            service.AddScoped<IPositionService, PositionService>();
            service.AddScoped<IEmployeeService, EmployeeService>();
            service.AddScoped<IDepartamentService, DepartamentService>();
            service.AddScoped<IVacationAppService, VacationApplicationService>();
            service.AddScoped<IVacancyDaysService, VacationDaysService>();
            service.AddScoped<IUnitOfWork, UnitOfWorks>();
            service.AddScoped<IUserService, UserService>();
            service.AddScoped<IAuthService, AuthServise>();
            service.AddScoped<IRoleService, RoleService>();
            service.AddScoped<IUserRoleService, UserRoleService>();
            service.AddScoped<IStatusService, StatusService>();
            service.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));
            service.AddScoped(typeof(ICRUDRepository<>), typeof(CRUDRepository<>));
        }
    }
}
