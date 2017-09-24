using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCMembership.Startup))]
namespace MVCMembership
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
