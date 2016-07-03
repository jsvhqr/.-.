using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AllianceFanshits.Startup))]
namespace AllianceFanshits
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
