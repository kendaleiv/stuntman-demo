using Microsoft.Owin;
using Owin;
using RimDev.Stuntman.Core;

[assembly: OwinStartup(typeof(StuntmanDemo.Mvc.Startup))]

namespace StuntmanDemo.Mvc
{
    public class Startup
    {
        public static readonly StuntmanOptions StuntmanOptions = new StuntmanOptions();

        public void Configuration(IAppBuilder app)
        {
            StuntmanOptions
                .AddUser(new StuntmanUser("employee-1", "Employee 1")
                    .AddClaim(System.Security.Claims.ClaimTypes.Role, "Employee"))

                .AddUser(new StuntmanUser("administrator-1", "Administrator 1")
                    .AddClaim(System.Security.Claims.ClaimTypes.Role, "Employee")
                    .AddClaim(System.Security.Claims.ClaimTypes.Role, "Administrator"))

                .AddUser(new StuntmanUser("api-user-1", "Api User 1")
                    .AddClaim(System.Security.Claims.ClaimTypes.Role, "Administrator")
                    .SetAccessToken("abc123"));

            if (System.Web.HttpContext.Current.IsDebuggingEnabled)
            {
                app.UseStuntman(StuntmanOptions);
            }
        }
    }
}
