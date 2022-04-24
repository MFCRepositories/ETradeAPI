using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETradeAPI.Application.Repositories;
using ETradeAPI.Persistence.Contexts;
using ETradeAPI.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ETradeAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this  IServiceCollection services)
        {

            services.AddDbContext<ETradeAPIDbContext>(options => options.UseNpgsql(Configuration.ConnectionString),ServiceLifetime.Singleton);

            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository,CustomerWriteRepository>();
                   
            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
                     
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
        }
    }
}
