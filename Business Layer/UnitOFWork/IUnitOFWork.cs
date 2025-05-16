using Business_Layer.Repositories;
using Business_Logic.Models;
using Microsoft.AspNetCore.Identity;

namespace Business_Layer.UnitOFWork
{
    public interface IUnitOFWork
    {
        ICartRepository Cart { get; }
        IMedicineRepository Medicine { get; }
        IReportRepository ReportManager { get; }
        public IDateInformation DateManager { get; }
        UserManager<ApplicationUser> UserManager { get; }
        SignInManager<ApplicationUser> SignInManager { get; }
        RoleManager<IdentityRole> RoleManager { get; }
    }
}
