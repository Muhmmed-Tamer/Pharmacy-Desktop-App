using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic.Models
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<Cart> Carts { get; set; }
    }
}
