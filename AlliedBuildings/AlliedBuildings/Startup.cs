using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AlliedBuildings.Startup))]
namespace AlliedBuildings
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
