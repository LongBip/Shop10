using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Shop10.Startup))]
namespace Shop10
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
