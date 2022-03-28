using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using shoppingAPP_MVC.Areas.Identity.Data;
using shoppingAPP_MVC.Data;

[assembly: HostingStartup(typeof(shoppingAPP_MVC.Areas.Identity.IdentityHostingStartup))]
namespace shoppingAPP_MVC.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<shoppingAPP_MVCContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("shoppingAPP_MVCContextConnection")));

                services.AddDefaultIdentity<shoppingAPP_MVCUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<shoppingAPP_MVCContext>();
            });
        }
    }
}