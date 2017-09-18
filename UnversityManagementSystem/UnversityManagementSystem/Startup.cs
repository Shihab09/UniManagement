using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UnversityManagementSystem.Startup))]
namespace UnversityManagementSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
