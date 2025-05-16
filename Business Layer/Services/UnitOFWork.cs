using Business_Layer.Repositories;
using Business_Layer.UnitOFWork;
using Business_Logic.Models;
using Microsoft.AspNetCore.Identity;

namespace Business_Layer.Services
{
    public class UnitOFWork : IUnitOFWork
    {
        public ICartRepository Cart { get; }

        public IMedicineRepository Medicine { get; }

        public UserManager<ApplicationUser> UserManager { get; }

        public SignInManager<ApplicationUser> SignInManager { get; }

        public RoleManager<IdentityRole> RoleManager { get; }

        public IReportRepository ReportManager { get; }
        public IDateInformation DateManager { get; }

        public UnitOFWork(ICartRepository Cart, IMedicineRepository Medicine, UserManager<ApplicationUser> UserManager,
            SignInManager<ApplicationUser> signInManager, RoleManager<IdentityRole> RoleManager, IReportRepository ReportMangaer, IDateInformation dateManager)
        {
            this.RoleManager = RoleManager;
            this.Medicine = Medicine;
            this.Cart = Cart;
            this.UserManager = UserManager;
            this.SignInManager = signInManager;
            this.ReportManager = ReportMangaer;
            DateManager = dateManager;
        }
    }
}
