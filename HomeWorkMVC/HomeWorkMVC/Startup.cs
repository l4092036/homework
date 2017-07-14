using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HomeWorkMVC.Startup))]
namespace HomeWorkMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
