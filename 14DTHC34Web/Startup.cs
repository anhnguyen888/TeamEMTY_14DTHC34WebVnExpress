using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_14DTHC34Web.Startup))]
namespace _14DTHC34Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
