using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ResturantBookingWebApp.Startup))]
namespace ResturantBookingWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
