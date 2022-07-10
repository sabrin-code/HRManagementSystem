using Microsoft.Extensions.DependencyInjection;
using System;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagemntSystem.Application
{
    public  static class RegisterServices
    {
        public static void AddApplicationServices( this IServiceCollection services)
        {
            services.AddMediatR(typeof(RegisterServices));
        }
    }
}
