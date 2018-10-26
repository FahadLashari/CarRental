using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarrentalMVC.Startup))]
namespace CarrentalMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
