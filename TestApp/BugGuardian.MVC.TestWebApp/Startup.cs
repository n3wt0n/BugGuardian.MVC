using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BugGuardian.MVC.TestWebApp.Startup))]
namespace BugGuardian.MVC.TestWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
