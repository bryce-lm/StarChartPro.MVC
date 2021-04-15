using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StarChartPro.MVC.Startup))]
namespace StarChartPro.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
