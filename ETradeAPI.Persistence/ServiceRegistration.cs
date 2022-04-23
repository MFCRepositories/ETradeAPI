using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETradeAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ETradeAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this  IServiceCollection services)
        {

            services.AddDbContext<ETradeAPIDbContext>(

                options => options.UseNpgsql(Configuration.ConnectionString)

            );
        }
    }
}
