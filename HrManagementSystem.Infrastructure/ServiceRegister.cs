using HrManagementSystem.Infrastructure.Operations;
using HrManagemntSystem.Application.Abstraction.Token;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagementSystem.Infrastructure
{
    public static class ServiceRegister
    {
        public static void AddInfrastructureServices( this IServiceCollection services)
        {
            services.AddScoped<ITokenHandler, TokenHandler>();
        }
    }
}
