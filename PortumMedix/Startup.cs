using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PortumMedix.Startup))]
namespace PortumMedix
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
