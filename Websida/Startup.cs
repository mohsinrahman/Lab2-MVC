using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Websida.Startup))]
namespace Websida
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
