using Business_Logic.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic.Data
{
    public class ContextData : IdentityDbContext<ApplicationUser>
    {        
        
        public ContextData(DbContextOptions<ContextData> Options) : base(Options)
        {
        }       

        public virtual DbSet<Medicine> Medicines { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }        
    }
}