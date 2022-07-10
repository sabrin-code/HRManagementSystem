using HrManagementSystem.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagementSystem.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<HRDbContext>
    {
        public HRDbContext CreateDbContext(string[] args)
        {

           
            DbContextOptionsBuilder<HRDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseSqlServer(Configure.ConnectionString);
            return new(dbContextOptionsBuilder.Options);
        }
    }
}
