using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using shoppingAPP_MVC.Areas.Identity.Data;

namespace shoppingAPP_MVC.Data
{
    public class shoppingAPP_MVCContext : IdentityDbContext<shoppingAPP_MVCUser>
    {
        public shoppingAPP_MVCContext(DbContextOptions<shoppingAPP_MVCContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
