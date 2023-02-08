using Microsoft.Extensions.DependencyInjection;
using MyProject.Context;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using MyProject.Services.Interfaces;
using MyProject.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProject.Repositories;
namespace MyProject.Services
{
   public static class Extentions
    {
       public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddRepositories();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IChildService, ChildService>();
            services.AddDbContext<IContext, MyDbContext>();
            services.AddAutoMapper(typeof(Mapping));
            return services;
        }
    }
}
