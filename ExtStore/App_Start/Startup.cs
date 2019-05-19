using Microsoft.Owin;
using Owin;
using ExtStore.Models.User;
using Microsoft.Owin.Security.Cookies;
using Microsoft.AspNet.Identity;
using ExtStore.DAL;

[assembly: OwinStartup(typeof(ExtStore.Startup))]

namespace ExtStore
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.CreatePerOwinContext<ApplicationContext>(ApplicationContext.Create);
            app.CreatePerOwinContext<MyUserManager>(MyUserManager.Create);

            // регистрация менеджера ролей
            app.CreatePerOwinContext<MyRoleManager>(MyRoleManager.Create);

            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login"),
            });
        }
    }
}