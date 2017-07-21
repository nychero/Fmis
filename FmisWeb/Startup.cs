using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FmisWeb.Startup))]
namespace FmisWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
