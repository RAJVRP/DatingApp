using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Interfaces;
using API.Services;
using Microsoft.EntityFrameworkCore;

namespace API.Extentions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddAppliicationServices(this IServiceCollection services, IConfiguration _Config)
        {
            services.AddScoped<ITokenService,TokenService>();


            services.AddDbContext<DataContext>(options =>    
            {
                options.UseSqlite(_Config.GetConnectionString("DefaultConnetion"));

            });
            return services;
        }
    }
}