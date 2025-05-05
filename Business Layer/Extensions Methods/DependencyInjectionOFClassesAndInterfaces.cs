using Business_Layer.Repositories;
using Business_Layer.Services;
using Business_Layer.UnitOFWork;
using Microsoft.Extensions.DependencyInjection;

namespace Business_Layer.Extensions_Methods
{
    public static class DependencyInjectionOFClassesAndInterfaces
    {
        public static void AddBusinessLayer(this IServiceCollection services)
        {
            services.AddScoped<IUnitOFWork, Business_Layer.Services.UnitOFWork>();
            services.AddScoped<ICartRepository, CartRepository>();
            services.AddScoped<IMedicineRepository, MedicineRepository>();
            services.AddScoped<IReportRepository, ReportRepository>();
            services.AddScoped<IDateInformation, DateInformation>();
        }
    }
}
