using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WorkShop.Web.Startup))]
namespace WorkShop.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
