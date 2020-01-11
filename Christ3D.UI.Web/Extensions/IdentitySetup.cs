using System;
using System.Threading.Tasks;
using AutoMapper;
using Christ3D.Application.AutoMapper;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Logging;

namespace Christ3D.UI.Web.Extensions
{
    /// <summary>
    /// AutoMapper 的启动服务
    /// </summary>
    public static class IdentitySetup
    {

        public static void AddIdentitySetup(this IServiceCollection services,IConfiguration Configuration)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));


            //services.AddDbContext<ApplicationDbContext>(options =>
            //   options.UseSqlServer(DbConfig.InitConn(Configuration.GetConnectionString("DefaultConnection_file"), Configuration.GetConnectionString("DefaultConnection"))));

            //services.AddIdentity<ApplicationUser, IdentityRole>()
            //    .AddEntityFrameworkStores<ApplicationDbContext>()
            //    .AddDefaultTokenProviders();

            //services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            //    .AddCookie(o =>
            //    {
            //        o.LoginPath = new PathString("/login");
            //        o.AccessDeniedPath = new PathString("/home/access-denied");
            //    })
            //    ;


        }


    }
}