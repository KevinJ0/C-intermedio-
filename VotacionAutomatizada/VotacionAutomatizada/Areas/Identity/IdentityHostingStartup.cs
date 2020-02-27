using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VotacionAutomatizada.Data;

[assembly: HostingStartup(typeof(VotacionAutomatizada.Areas.Identity.IdentityHostingStartup))]
namespace VotacionAutomatizada.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<VotacionAutomatizadaContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("VotacionAutomatizadaContextConnection")));

                services.AddDefaultIdentity<IdentityUser>()
                    .AddEntityFrameworkStores<VotacionAutomatizadaContext>();
            });
        }
    }
}