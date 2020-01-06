using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASM_EAP_NguyenTuanAnh026.App_Start;
using ASM_EAP_NguyenTuanAnh026.Models;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASM_EAP_NguyenTuanAnh026.Startup))]
namespace ASM_EAP_NguyenTuanAnh026
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.CreatePerOwinContext<MyDbContext>(MyDbContext.Create);
            app.CreatePerOwinContext<MyUserManager>(MyUserManager.Create);
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Accounts/Login")
            });
        }
    }
}