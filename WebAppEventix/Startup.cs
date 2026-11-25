using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppEventix.Startup))]
namespace WebAppEventix
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
