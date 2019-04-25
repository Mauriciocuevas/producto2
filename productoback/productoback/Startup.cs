using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(productoback.Startup))]
namespace productoback
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
