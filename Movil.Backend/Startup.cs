using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Movil.Backend.Startup))]
namespace Movil.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
