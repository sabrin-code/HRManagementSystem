using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagementSystem.Persistence
{
    public static class Configure
    {
        public static string ConnectionString
        {
            get
            {
                IConfigurationRoot conf = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
                return conf.GetConnectionString("SqlServer");
            }
        }
    }
}
