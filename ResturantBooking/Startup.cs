using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ResturantBooking.Startup))]
namespace ResturantBooking
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
