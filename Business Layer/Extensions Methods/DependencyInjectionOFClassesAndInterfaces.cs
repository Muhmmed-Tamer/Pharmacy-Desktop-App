using Business_Layer.Repositories;
using Business_Layer.Services;
using Business_Layer.UnitOFWork;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.Extensions_Methods
{
    public static class DependencyInjectionOFClassesAndInterfaces
    {
        public static void AddBusinessLayer(this IServiceCollection services)
        {
            services.AddScoped<IUnitOFWork, Business_Layer.Services.UnitOFWork>();
            services.AddScoped<ICartRepository, CartRepository>();
            services.AddScoped<IMedicineRepository, MedicineRepository>();            
        }
    }
}
