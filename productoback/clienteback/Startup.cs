using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(clienteback.Startup))]
namespace clienteback
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
