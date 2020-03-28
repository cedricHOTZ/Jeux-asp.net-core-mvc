using System;
using jeuxdontonestleheros.Backoffice.WEB.UI.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(jeuxdontonestleheros.Backoffice.WEB.UI.Areas.Identity.IdentityHostingStartup))]
namespace jeuxdontonestleheros.Backoffice.WEB.UI.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<jeuxdontonestleherosBackofficeWEBUIContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("jeuxdontonestleherosBackofficeWEBUIContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<jeuxdontonestleherosBackofficeWEBUIContext>();
            });
        }
    }
}