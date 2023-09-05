using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LaPoderosaWeb.Startup))]
namespace LaPoderosaWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
