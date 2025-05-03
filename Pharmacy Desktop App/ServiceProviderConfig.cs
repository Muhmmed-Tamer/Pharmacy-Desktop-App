using Business_Layer.Repositories;
using Business_Layer.Services;
using Business_Layer.UnitOFWork;
using Business_Logic.Data;
using Business_Logic.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Business_Layer.Extensions_Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pharmacy_Desktop_App.Admin;
using Pharmacy_Desktop_App.Pharmacist;

namespace Pharmacy_Desktop_App
{
    public static class ServiceProviderConfig
    {
        public static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            // Configure DbContext (you'll need to add your DbContext)
            services.AddDbContext<ContextData>(options =>
                options.UseSqlServer("Data Source = .; Initial Catalog = PharmacyDesktopAppDataBase; Integrated Security = True;TrustServerCertificate=True"));

            // Add Identity
            services.AddIdentity<ApplicationUser, IdentityRole>(
                    Options =>
                    {
                        Options.Password.RequireDigit = false;
                        Options.Password.RequiredLength = 4;
                        Options.Password.RequireNonAlphanumeric = false;
                        Options.Password.RequireUppercase = false;
                        Options.Password.RequireLowercase = false;
                        Options.User.RequireUniqueEmail = true;
                    }
                )
                .AddEntityFrameworkStores<ContextData>()
                .AddDefaultTokenProviders();

            // Add your repositories
            services.AddBusinessLayer();
            services.AddTransient<Login>();
            services.AddTransient<AddUserButton>();
            services.AddTransient<DashboardOFAdmin>();
            services.AddTransient<ViewUsers>();
            services.AddTransient<DashboardOFPharmacist>();
            services.AddTransient<AddMedicine>();
            services.AddTransient<VaildityCheck>();
            services.AddLogging();

            // Add any other services you need

            return services.BuildServiceProvider();
        }
    }
}
