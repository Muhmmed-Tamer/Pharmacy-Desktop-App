using Business_Layer.Repositories;
using Business_Layer.Services;
using Business_Logic.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.UnitOFWork
{
    public interface IUnitOFWork
    {
        ICartRepository Cart { get; }        
        IMedicineRepository Medicine { get; }
        UserManager<ApplicationUser> UserManager { get; }
        SignInManager<ApplicationUser> SignInManager { get; }
        RoleManager<IdentityRole> RoleManager { get; }
    }
}
